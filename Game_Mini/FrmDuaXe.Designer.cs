namespace Game_Mini
{
    partial class FrmDuaXe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuaXe));
            this.pbNen = new System.Windows.Forms.PictureBox();
            this.pbDuong = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pbXe = new System.Windows.Forms.PictureBox();
            this.pbVC1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbVC2 = new System.Windows.Forms.PictureBox();
            this.pbVC3 = new System.Windows.Forms.PictureBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.gbGameOver = new System.Windows.Forms.GroupBox();
            this.bttHome = new System.Windows.Forms.Button();
            this.bttHelp = new System.Windows.Forms.Button();
            this.lbKQ_Diem = new System.Windows.Forms.Label();
            this.bttAgain = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.TimerDiem = new System.Windows.Forms.Timer(this.components);
            this.bttStart = new System.Windows.Forms.Button();
            this.bttTrai = new System.Windows.Forms.Button();
            this.bttPhai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC3)).BeginInit();
            this.gbGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbNen
            // 
            this.pbNen.Image = global::Game_Mini.Properties.Resources.Hinh_Itachi;
            this.pbNen.Location = new System.Drawing.Point(0, 0);
            this.pbNen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbNen.Name = "pbNen";
            this.pbNen.Size = new System.Drawing.Size(996, 812);
            this.pbNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNen.TabIndex = 0;
            this.pbNen.TabStop = false;
            // 
            // pbDuong
            // 
            this.pbDuong.Image = ((System.Drawing.Image)(resources.GetObject("pbDuong.Image")));
            this.pbDuong.Location = new System.Drawing.Point(300, 2);
            this.pbDuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbDuong.Name = "pbDuong";
            this.pbDuong.Size = new System.Drawing.Size(391, 810);
            this.pbDuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDuong.TabIndex = 1;
            this.pbDuong.TabStop = false;
            this.pbDuong.Tag = "";
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(0, 811);
            this.pb2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(996, 266);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pbXe
            // 
            this.pbXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbXe.BackColor = System.Drawing.Color.LightGray;
            this.pbXe.Image = global::Game_Mini.Properties.Resources.XE1;
            this.pbXe.Location = new System.Drawing.Point(454, 593);
            this.pbXe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbXe.Name = "pbXe";
            this.pbXe.Size = new System.Drawing.Size(84, 123);
            this.pbXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbXe.TabIndex = 6;
            this.pbXe.TabStop = false;
            // 
            // pbVC1
            // 
            this.pbVC1.BackColor = System.Drawing.Color.White;
            this.pbVC1.Image = global::Game_Mini.Properties.Resources.mat_ban;
            this.pbVC1.Location = new System.Drawing.Point(315, 789);
            this.pbVC1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbVC1.Name = "pbVC1";
            this.pbVC1.Size = new System.Drawing.Size(101, 52);
            this.pbVC1.TabIndex = 7;
            this.pbVC1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbVC2
            // 
            this.pbVC2.BackColor = System.Drawing.Color.White;
            this.pbVC2.Image = global::Game_Mini.Properties.Resources.mat_ban;
            this.pbVC2.Location = new System.Drawing.Point(448, 230);
            this.pbVC2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbVC2.Name = "pbVC2";
            this.pbVC2.Size = new System.Drawing.Size(101, 52);
            this.pbVC2.TabIndex = 8;
            this.pbVC2.TabStop = false;
            // 
            // pbVC3
            // 
            this.pbVC3.BackColor = System.Drawing.Color.White;
            this.pbVC3.Image = global::Game_Mini.Properties.Resources.mat_ban;
            this.pbVC3.Location = new System.Drawing.Point(576, 400);
            this.pbVC3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbVC3.Name = "pbVC3";
            this.pbVC3.Size = new System.Drawing.Size(101, 52);
            this.pbVC3.TabIndex = 9;
            this.pbVC3.TabStop = false;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(930, 811);
            this.txtText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(65, 30);
            this.txtText.TabIndex = 11;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // gbGameOver
            // 
            this.gbGameOver.BackgroundImage = global::Game_Mini.Properties.Resources.Game_over;
            this.gbGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbGameOver.Controls.Add(this.bttHome);
            this.gbGameOver.Controls.Add(this.bttHelp);
            this.gbGameOver.Controls.Add(this.lbKQ_Diem);
            this.gbGameOver.Controls.Add(this.bttAgain);
            this.gbGameOver.Location = new System.Drawing.Point(262, 300);
            this.gbGameOver.Name = "gbGameOver";
            this.gbGameOver.Size = new System.Drawing.Size(480, 308);
            this.gbGameOver.TabIndex = 13;
            this.gbGameOver.TabStop = false;
            // 
            // bttHome
            // 
            this.bttHome.BackgroundImage = global::Game_Mini.Properties.Resources.nen2;
            this.bttHome.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttHome.ForeColor = System.Drawing.Color.White;
            this.bttHome.Location = new System.Drawing.Point(53, 235);
            this.bttHome.Name = "bttHome";
            this.bttHome.Size = new System.Drawing.Size(101, 52);
            this.bttHome.TabIndex = 3;
            this.bttHome.Text = "Home";
            this.bttHome.UseVisualStyleBackColor = true;
            this.bttHome.Click += new System.EventHandler(this.bttHome_Click);
            // 
            // bttHelp
            // 
            this.bttHelp.BackgroundImage = global::Game_Mini.Properties.Resources.nen2;
            this.bttHelp.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttHelp.ForeColor = System.Drawing.Color.White;
            this.bttHelp.Location = new System.Drawing.Point(335, 235);
            this.bttHelp.Name = "bttHelp";
            this.bttHelp.Size = new System.Drawing.Size(103, 52);
            this.bttHelp.TabIndex = 2;
            this.bttHelp.Text = "Help";
            this.bttHelp.UseVisualStyleBackColor = true;
            this.bttHelp.Click += new System.EventHandler(this.bttHelp_Click);
            // 
            // lbKQ_Diem
            // 
            this.lbKQ_Diem.BackColor = System.Drawing.Color.White;
            this.lbKQ_Diem.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKQ_Diem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbKQ_Diem.Image = global::Game_Mini.Properties.Resources.nen2;
            this.lbKQ_Diem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbKQ_Diem.Location = new System.Drawing.Point(0, 0);
            this.lbKQ_Diem.Name = "lbKQ_Diem";
            this.lbKQ_Diem.Size = new System.Drawing.Size(480, 62);
            this.lbKQ_Diem.TabIndex = 1;
            this.lbKQ_Diem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttAgain
            // 
            this.bttAgain.BackgroundImage = global::Game_Mini.Properties.Resources.nen2;
            this.bttAgain.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttAgain.ForeColor = System.Drawing.Color.White;
            this.bttAgain.Location = new System.Drawing.Point(175, 226);
            this.bttAgain.Name = "bttAgain";
            this.bttAgain.Size = new System.Drawing.Size(133, 61);
            this.bttAgain.TabIndex = 0;
            this.bttAgain.Text = "Play";
            this.bttAgain.UseVisualStyleBackColor = true;
            this.bttAgain.Click += new System.EventHandler(this.bttAgain_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDiem.ForeColor = System.Drawing.Color.White;
            this.lbDiem.Image = global::Game_Mini.Properties.Resources.nen2;
            this.lbDiem.Location = new System.Drawing.Point(300, 0);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(391, 60);
            this.lbDiem.TabIndex = 14;
            this.lbDiem.Text = "0m";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerDiem
            // 
            this.TimerDiem.Interval = 200;
            this.TimerDiem.Tick += new System.EventHandler(this.TimerDiem_Tick);
            // 
            // bttStart
            // 
            this.bttStart.BackColor = System.Drawing.Color.LightGray;
            this.bttStart.Image = global::Game_Mini.Properties.Resources.Start2;
            this.bttStart.Location = new System.Drawing.Point(315, 339);
            this.bttStart.Name = "bttStart";
            this.bttStart.Size = new System.Drawing.Size(357, 158);
            this.bttStart.TabIndex = 2;
            this.bttStart.UseVisualStyleBackColor = false;
            this.bttStart.Click += new System.EventHandler(this.bttStart_Click);
            // 
            // bttTrai
            // 
            this.bttTrai.BackgroundImage = global::Game_Mini.Properties.Resources.Trai;
            this.bttTrai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttTrai.ForeColor = System.Drawing.Color.Black;
            this.bttTrai.Location = new System.Drawing.Point(410, 632);
            this.bttTrai.Name = "bttTrai";
            this.bttTrai.Size = new System.Drawing.Size(37, 48);
            this.bttTrai.TabIndex = 15;
            this.bttTrai.UseVisualStyleBackColor = true;
            this.bttTrai.Click += new System.EventHandler(this.bttTrai_Click);
            // 
            // bttPhai
            // 
            this.bttPhai.BackgroundImage = global::Game_Mini.Properties.Resources.Phai;
            this.bttPhai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttPhai.ForeColor = System.Drawing.Color.Black;
            this.bttPhai.Location = new System.Drawing.Point(545, 632);
            this.bttPhai.Name = "bttPhai";
            this.bttPhai.Size = new System.Drawing.Size(37, 48);
            this.bttPhai.TabIndex = 16;
            this.bttPhai.UseVisualStyleBackColor = true;
            this.bttPhai.Click += new System.EventHandler(this.bttPhai_Click);
            // 
            // FrmDuaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(996, 1055);
            this.Controls.Add(this.bttPhai);
            this.Controls.Add(this.bttTrai);
            this.Controls.Add(this.gbGameOver);
            this.Controls.Add(this.bttStart);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.pbXe);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pbVC3);
            this.Controls.Add(this.pbVC2);
            this.Controls.Add(this.pbVC1);
            this.Controls.Add(this.pbDuong);
            this.Controls.Add(this.pbNen);
            this.Controls.Add(this.txtText);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDuaXe";
            this.Text = " Dua Xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVC3)).EndInit();
            this.gbGameOver.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbNen;
        private PictureBox pbDuong;
        private PictureBox pb2;
        private PictureBox pbXe;
        private PictureBox pbVC1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbVC2;
        private PictureBox pbVC3;
        private TextBox txtText;
        private GroupBox gbGameOver;
        private Button bttAgain;
        private Label lbDiem;
        private System.Windows.Forms.Timer TimerDiem;
        private Label lbKQ_Diem;
        private Button bttStart;
        private Button bttHelp;
        private Button bttHome;
        private Button bttTrai;
        private Button bttPhai;
    }
}