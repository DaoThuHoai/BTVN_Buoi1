namespace ThemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDangNhap = new System.Windows.Forms.TextBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.labelStt = new System.Windows.Forms.Label();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.groupBoxThemSV = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.textBoxMaSv = new System.Windows.Forms.TextBox();
            this.textBoxTenSV = new System.Windows.Forms.TextBox();
            this.buttonThemSV = new System.Windows.Forms.Button();
            this.dGVThemSV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxThemSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThemSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // textBoxDangNhap
            // 
            this.textBoxDangNhap.Location = new System.Drawing.Point(641, 22);
            this.textBoxDangNhap.Name = "textBoxDangNhap";
            this.textBoxDangNhap.Size = new System.Drawing.Size(167, 22);
            this.textBoxDangNhap.TabIndex = 2;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(641, 70);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(167, 22);
            this.textBoxMatKhau.TabIndex = 3;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonDangNhap.Location = new System.Drawing.Point(691, 114);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(117, 33);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng Nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // labelStt
            // 
            this.labelStt.AutoSize = true;
            this.labelStt.Location = new System.Drawing.Point(129, 187);
            this.labelStt.Name = "labelStt";
            this.labelStt.Size = new System.Drawing.Size(0, 17);
            this.labelStt.TabIndex = 5;
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(688, 162);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 17);
            this.lblthongbao.TabIndex = 6;
            // 
            // groupBoxThemSV
            // 
            this.groupBoxThemSV.Controls.Add(this.dGVThemSV);
            this.groupBoxThemSV.Controls.Add(this.buttonThemSV);
            this.groupBoxThemSV.Controls.Add(this.textBoxTenSV);
            this.groupBoxThemSV.Controls.Add(this.textBoxMaSv);
            this.groupBoxThemSV.Controls.Add(this.lblTen);
            this.groupBoxThemSV.Controls.Add(this.lblMaSV);
            this.groupBoxThemSV.Location = new System.Drawing.Point(146, 244);
            this.groupBoxThemSV.Name = "groupBoxThemSV";
            this.groupBoxThemSV.Size = new System.Drawing.Size(809, 318);
            this.groupBoxThemSV.TabIndex = 7;
            this.groupBoxThemSV.TabStop = false;
            this.groupBoxThemSV.Text = "Thêm Sinh Viên";
            this.groupBoxThemSV.Enter += new System.EventHandler(this.groupBoxThemSV_Enter);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(422, 46);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(37, 17);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "MSV";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(422, 100);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(55, 17);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên SV";
            // 
            // textBoxMaSv
            // 
            this.textBoxMaSv.Location = new System.Drawing.Point(524, 41);
            this.textBoxMaSv.Name = "textBoxMaSv";
            this.textBoxMaSv.Size = new System.Drawing.Size(172, 22);
            this.textBoxMaSv.TabIndex = 2;
            // 
            // textBoxTenSV
            // 
            this.textBoxTenSV.Location = new System.Drawing.Point(524, 95);
            this.textBoxTenSV.Name = "textBoxTenSV";
            this.textBoxTenSV.Size = new System.Drawing.Size(172, 22);
            this.textBoxTenSV.TabIndex = 3;
            // 
            // buttonThemSV
            // 
            this.buttonThemSV.Location = new System.Drawing.Point(606, 138);
            this.buttonThemSV.Name = "buttonThemSV";
            this.buttonThemSV.Size = new System.Drawing.Size(75, 26);
            this.buttonThemSV.TabIndex = 4;
            this.buttonThemSV.Text = "Thêm";
            this.buttonThemSV.UseVisualStyleBackColor = true;
            this.buttonThemSV.Click += new System.EventHandler(this.buttonThemSV_Click);
            // 
            // dGVThemSV
            // 
            this.dGVThemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dGVThemSV.Location = new System.Drawing.Point(32, 41);
            this.dGVThemSV.Name = "dGVThemSV";
            this.dGVThemSV.RowHeadersWidth = 51;
            this.dGVThemSV.RowTemplate.Height = 24;
            this.dGVThemSV.Size = new System.Drawing.Size(364, 249);
            this.dGVThemSV.TabIndex = 5;
            this.dGVThemSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1103, 604);
            this.Controls.Add(this.groupBoxThemSV);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.labelStt);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.textBoxDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormThemSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxThemSV.ResumeLayout(false);
            this.groupBoxThemSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThemSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Label labelStt;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.GroupBox groupBoxThemSV;
        private System.Windows.Forms.Button buttonThemSV;
        private System.Windows.Forms.TextBox textBoxTenSV;
        private System.Windows.Forms.TextBox textBoxMaSv;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.DataGridView dGVThemSV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

