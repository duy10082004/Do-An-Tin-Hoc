namespace QuanLyKhoHang
{
    partial class QuanLy
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
            this.khBtnExit = new System.Windows.Forms.Button();
            this.dgvQuanLyHangHoa = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // khBtnExit
            // 
            this.khBtnExit.Location = new System.Drawing.Point(12, 409);
            this.khBtnExit.Name = "khBtnExit";
            this.khBtnExit.Size = new System.Drawing.Size(78, 29);
            this.khBtnExit.TabIndex = 1;
            this.khBtnExit.Text = "Thoát";
            this.khBtnExit.UseVisualStyleBackColor = true;
            this.khBtnExit.Click += new System.EventHandler(this.khBtnExit_Click);
            // 
            // dgvQuanLyHangHoa
            // 
            this.dgvQuanLyHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyHangHoa.Location = new System.Drawing.Point(12, 28);
            this.dgvQuanLyHangHoa.Name = "dgvQuanLyHangHoa";
            this.dgvQuanLyHangHoa.Size = new System.Drawing.Size(766, 350);
            this.dgvQuanLyHangHoa.TabIndex = 2;
            this.dgvQuanLyHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyHangHoa_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvQuanLyHangHoa);
            this.Controls.Add(this.khBtnExit);
            this.Name = "QuanLy";
            this.Text = "KhoHang";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button khBtnExit;
        private System.Windows.Forms.DataGridView dgvQuanLyHangHoa;
        private System.Windows.Forms.Button button1;
    }
}