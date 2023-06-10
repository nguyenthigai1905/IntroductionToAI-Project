
namespace TikiCrawler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_limit = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_limit = new System.Windows.Forms.TextBox();
            this.btn_getData = new System.Windows.Forms.Button();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_url.Location = new System.Drawing.Point(44, 14);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(167, 29);
            this.lbl_url.TabIndex = 0;
            this.lbl_url.Text = "Link sản phẩm";
            // 
            // lbl_limit
            // 
            this.lbl_limit.AutoSize = true;
            this.lbl_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limit.Location = new System.Drawing.Point(44, 281);
            this.lbl_limit.Name = "lbl_limit";
            this.lbl_limit.Size = new System.Drawing.Size(279, 29);
            this.lbl_limit.TabIndex = 1;
            this.lbl_limit.Text = "Số lượng comment tối đa";
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(49, 54);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(357, 215);
            this.txt_url.TabIndex = 2;
            // 
            // txt_limit
            // 
            this.txt_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limit.Location = new System.Drawing.Point(329, 275);
            this.txt_limit.Name = "txt_limit";
            this.txt_limit.Size = new System.Drawing.Size(77, 35);
            this.txt_limit.TabIndex = 3;
            this.txt_limit.Text = "10";
            // 
            // btn_getData
            // 
            this.btn_getData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getData.Location = new System.Drawing.Point(49, 328);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Size = new System.Drawing.Size(357, 94);
            this.btn_getData.TabIndex = 4;
            this.btn_getData.Text = "LẤY DỮ LIỆU";
            this.btn_getData.UseVisualStyleBackColor = true;
            this.btn_getData.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_res
            // 
            this.txt_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_res.Location = new System.Drawing.Point(444, 54);
            this.txt_res.Multiline = true;
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(416, 256);
            this.txt_res.TabIndex = 5;
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(444, 328);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(200, 94);
            this.btn_copy.TabIndex = 6;
            this.btn_copy.Text = "COPY";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(861, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(52, 43);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(660, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 94);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "LƯU FILE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dữ liệu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(912, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.btn_getData);
            this.Controls.Add(this.txt_limit);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_limit);
            this.Controls.Add(this.lbl_url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Shopee";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label lbl_limit;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_limit;
        private System.Windows.Forms.Button btn_getData;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
    }
}

