using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using xNet;
using Newtonsoft.Json.Linq;

namespace TikiCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MODE = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void getMode()
        {
            string url = txt_url.Text;
            if (url.Length < 20) return;
            for (int i = 0; i <= 10; ++i)
            {
                string tmp = "";
                for (int j = i; j < i + 4; ++j)
                    tmp += url[j];
                if (tmp == "tiki")
                {
                    MODE = 0;
                    return;
                }
            }
            MODE = 1;
        }
        private string getIdTiki()
        {
            string tmp = txt_url.Text;
            string res0 = "", res = "";
            int pos = 0;
            for (int i = tmp.Length - 4; i > 0; --i)
            {
                string temp = "";
                for (int j = i; j <= i + 3; ++j)
                    temp += tmp[j];
                if (temp == "html")
                {
                    pos = i - 2;
                    break;
                }

            }
            while (tmp[pos] != 'p')
            {
                res0 = res0 + tmp[pos];
                --pos;
            }
            for (int i = res0.Length - 1; i >= 0; --i)
                res += res0[i];
            return res;
        }

        private string getIdShopee()
        {
            string tmp = txt_url.Text + "?";
            string res = "";
            int pos = 0;
            for (int i = 20; i < tmp.Length; ++i)
            {
                string tmp0 = "" + tmp[i] + tmp[i + 1];
                if (tmp0 == "i.")
                {
                    pos = i + 2;
                    break;
                }
            }    
            while (tmp[pos]!='?')
            {
                res += tmp[pos];
                ++pos;
            }
            return res;
        }

        private void getDataTiki()
        {
            string URL = "https://tiki.vn/api/v2/reviews?limit=" + txt_limit.Text + "&include=comments,contribute_info&sort=score%7Cdesc,id%7Cdesc,stars%7Call&page=1&product_id=" + getIdTiki();
            HttpRequest http = new HttpRequest();
            string html = http.Get(URL).ToString();
            txt_res.Text = html;
        }

        private void getDataShopee()
        {
            string shopId = "", productId = "";
            string tmp = getIdShopee();
            int pos = 0;
            while (tmp[pos] != '.')
            {
                shopId += tmp[pos];
                pos++;
            }
            ++pos;
            for (int i = pos; i < tmp.Length; ++i)
                productId += tmp[i];
            int lim = int.Parse(txt_limit.Text);
            if (lim < 50)
            {
                string URL = "https://shopee.vn/api/v2/item/get_ratings?filter=0&flag=1&itemid=" + productId
                    + "&limit=" + txt_limit.Text + "&shopid=" + shopId + "&type=0";
                HttpRequest http = new HttpRequest();
                string html = http.Get(URL).ToString();
                JObject jss = JObject.Parse(html);
                JArray temparray = (JArray)jss["data"]["ratings"];
                txt_res.Text = temparray.ToString();
            }
            else
            {
                int t = lim / 50;
                JArray jArray = new JArray();
                for (int i = 0; i < t; ++i)
                {
                    int offset = i * 50;
                    string URL = "https://shopee.vn/api/v2/item/get_ratings?filter=0&flag=1&itemid=" + productId
                    + "&limit=50&offset=" + offset.ToString() + "&shopid=" + shopId + "&type=0";
                    HttpRequest http = new HttpRequest();
                    string html = http.Get(URL).ToString();
                    JObject jss = JObject.Parse(html);
                    JArray temparray = (JArray)jss["data"]["ratings"];
                    jArray.Merge(temparray);
                }
                txt_res.Text = jArray.ToString();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                getMode();
            }
            catch
            {
                txt_res.Text = "URL hoặc số comment sai định dạng";
            }
            if (MODE == 0)
            {
                try
                {
                    getDataTiki();
                }
                catch
                {
                    txt_res.Text = "URL hoặc số comment sai định dạng";
                }
            }
            else
            {
                try
                {
                    getDataShopee();
                }
                catch
                {
                    txt_res.Text = "URL hoặc số comment sai định dạng";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // copy dữ liệu
        {
            Clipboard.SetText(txt_res.Text);
        }  

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) //kéo thả di chuyển ứng dụng
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e) // tắt ứng dụng
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e) // lưu file
        {
            string dataFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "data.json";
            File.WriteAllText(dataFilePath, txt_res.Text);
        }
    }
}
