using Game_Mini.Properties;
using System.Media;
using System.Security.Cryptography;


namespace Game_Mini
{
    public partial class FrmDuaXe : Form
    {
        private int diem;
        private int tocdo;
        System.Media.SoundPlayer sVaCham = new SoundPlayer(@"D://Data Cá Nhân\Game_Mini\Sound\Va_Cham.wav");
        System.Media.SoundPlayer sNhacNen = new SoundPlayer(@"D://Data Cá Nhân\Game_Mini\Sound\TiengXe.wav");
        public FrmDuaXe()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pbXe.Left = 454;
            pbVC1.Top = pbVC2.Top = pbVC3.Top = 2000;
            txtText.Enabled = false;
            gbGameOver.Hide();
            diem = 0;
            tocdo = 4;
            
        }
        // ------------Chay Game-----------
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbVC1.Top += tocdo;
            pbVC2.Top += tocdo;
            pbVC3.Top += tocdo;
            Random r = new Random();
            int i;
            i = r.Next(0, 200);
            if (i == 1 && pbVC1.Top >= 820) // den vi tri 820 (Location) la chua chay xog chu ki
            {
                pbVC1.Top = -50;
            }
            if (i == 3 && pbVC2.Top >= 820)
            {
                pbVC2.Top = -50;
            }
            if (i == 5 && pbVC3.Top >= 820)
            {
                pbVC3.Top = -50;
            }
            // --------TRUONG HOP THUA VI CHAM VAT CAN ----------
                if ( (pbVC1.Top >= 560 && pbXe.Left == 324 && pbVC1.Top < 680) || (pbVC2.Top >= 560 && pbXe.Left == 454 && pbVC2.Top < 680) 
                    || (pbVC3.Top >= 560 && pbXe.Left == 584 && pbVC3.Top < 680)    )
                {
                    sVaCham.Play();
                    timer1.Stop();
                    TimerDiem.Stop();
                    gbGameOver.Show();
                    lbKQ_Diem.Text = "SCORE: " + lbDiem.Text;
                    txtText.Enabled = false;
                   
                }
           
        }

        // -------- Nhan lenh dieu khien xe tai day!! ---------
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text.ToLower();
            if (txtText.Text == "a")
            {
                if (pbXe.Left > 324) // ko vuot qua le trai duong
                    pbXe.Left -= 130;
            }
            else if (txtText.Text == "d")
            {
                if (pbXe.Left < 584)  // ko vuot qua le phai duong
                    pbXe.Left += 130;
            }
            else if (txtText.Text == " ")
            {
                timer1.Enabled = !timer1.Enabled;
                TimerDiem.Enabled = !TimerDiem.Enabled;
            }

            txtText.Clear();
        }

        private void bttStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            bttStart.Hide();
            txtText.Enabled = true;
            txtText.Focus();
            TimerDiem.Start();
            System.Media.SystemSounds.Beep.Play();
            sNhacNen.PlayLooping();
            bttTrai.Hide(); bttPhai.Hide();
        }

        private void bttAgain_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            bttStart_Click(sender, e);
            
        }
        //---------------------TINH DIEM VA DO KHO GAME--------------------
        private void TimerDiem_Tick(object sender, EventArgs e)
        {
           lbDiem.Text = (diem += 1).ToString() + "m";
           // Tang do kho game sau moi 100d
           if (diem % 100 == 0)
           {
               tocdo++;
           }

           // ---Thay doi Backround---
           if (diem == 300)
                pbNen.Image = Resources.Hinh_Naruto;
           if (diem == 600)
                pbNen.Image = Resources.Hinh_OnePiece;
           if (diem == 900)
                pbNen.Image = Resources.Hinh_SonGoku;
           if (diem == 1200)
                pbNen.Image = Resources.Hinh_OPiece_3;
           if (diem == 1500)
                pbNen.Image = Resources.Hinh_OnePiece_2;
        }
        // --------------Giup do (Help)-----------
        private void bttHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Phím A để sang trái.\n  Phím D để sang phải.\n  Phím Space để Tiếp tục/Tạm dừng.", "Hướng dẫn chơi game",
                MessageBoxButtons.OK, MessageBoxIcon.Hand) ;
            
        }
        // ------------Tro ve man hinh chinh----------------
        private void bttHome_Click(object sender, EventArgs e)
        {
            gbGameOver.Hide();
            bttStart.Show();
            Form1_Load(sender, e);
            bttTrai.Show(); bttPhai.Show();
        }
        // -------------CHON LOAI XE------------
        private int SoXe = 1;
        private void LoaiXe()
        {
            if (SoXe == 1)
                pbXe.Image = Resources.XE1;
            else if (SoXe == 2)
                pbXe.Image = Resources.Xe_Blue;
            else if (SoXe == 3)
                pbXe.Image = Resources.Xe_Den;
            else 
                pbXe.Image = Resources.XE_F1;
        }
        private void bttTrai_Click(object sender, EventArgs e)
        {
            SoXe--;
            if (SoXe == 0)
                SoXe = 4;
            LoaiXe();
        }
        private void bttPhai_Click(object sender, EventArgs e)
        {
            SoXe++;
            if (SoXe == 5)
                SoXe = 1;
            LoaiXe();
        }
    }
}