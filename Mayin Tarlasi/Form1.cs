using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayin_Tarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timeLeft = 100;
        int NumberMines = 20;
        Minefield mField;
        Image MineImage = Image.FromFile(@"mayin.png");
        Image RstImage = Image.FromFile(@"Restart.png");
        Image ScreenShot = Image.FromFile(@"ScreenShot.png");
        Image Flame = Image.FromFile(@"Flame.png");
        Image VictoryImage = Image.FromFile(@"VictoryEmoji.png");
        Image NormalImage = Image.FromFile(@"Normal.png");
        Image SadImage = Image.FromFile(@"Sad.png");
        List<Mines> MineField_Found;
        int ClearField;

        private void Form1_Load(object sender, EventArgs e)
        {
            New_start_game();
            //DemonstareteMines();
            LabelTimeLeft.Text = "Time Left: " + timeLeft.ToString();
        }
        
        private void Textb_Result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int cont = Convert.ToInt32(textBox1.Text);
                if(cont > 0)
                {
                    NumberMines = cont;
                    panel1.Controls.Clear();
                    New_start_game();
                }
            }
        }

        public void New_start_game()
        {
            TimerCountDown.Start();
            timeLeft = 100;
            mField = new Minefield(new Size(400, 400), NumberMines);
            panel1.Size = mField.sphere; // Panel'in büyüklüğü tarlamızın büyüklüğüne eşit olmalı.
            ClearField = 0;
            button2.BackgroundImage = NormalImage;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Mines();
            //button1.BackgroundImage = RstImage;
            //button1.BackgroundImageLayout = ImageLayout.Stretch;
        }


        public void Add_Mines()
        {
            for(int i =0; i<panel1.Width; i+=20)
            {
                for(int j =0; j<panel1.Height; j+=20)
                {
                    Add_Button(new Point(i, j));
                }
            }
        }

        public void Add_Button (Point Loc)
        {
            Button btn = new Button();
            btn.Name = Loc.X +"" + Loc.Y;
            btn.Size = new Size(20, 20);
            btn.Location = Loc;
            btn.Click += new EventHandler(btn_Click); // Olay verisi olmayan bir olayı işleyecek yöntemi temsil eder.
            btn.MouseUp += new MouseEventHandler(btn_MouseUp);
            panel1.Controls.Add(btn);
        }

        void btn_MouseUp (object sender, MouseEventArgs e)
        {
            int remainingFlame = 10;
            Button btn = (sender as Button);
            if(e.Button == MouseButtons.Right && remainingFlame>0)
            {
                btn.BackgroundImage = Flame;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                remainingFlame -= 1;
            }
        }

        public void btn_Click (object sender, EventArgs e)
        {
            Button btn = (sender as Button); //Hangi butona tıklandığını bilmemiz lazım.
            Mines mine = mField.Mines_by_Location(btn.Location);
            MineField_Found = new List<Mines>();
            if(mine.IsThereMines)
            {
                //Süreyi Durdurma
                TimerCountDown.Stop();

                //Emoji Butonunun üzgün emojiye geçmesi
                button2.BackgroundImage = SadImage;
                button2.BackgroundImageLayout = ImageLayout.Stretch;

                // Kaybettin mesajının çıkması ve aynı zamanda tekrar oynamak isteyip istemdiğini öğrenme 
                MessageBox.Show("You lost.");
                DemonstareteMines();
                DialogResult dr = MessageBox.Show("Do you want to play again?", "Time is over", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    panel1.Controls.Clear();
                    NumberMines = 20;
                    New_start_game();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                int numb = MinesAreAround(mine); 
                if(numb==0)
                {
                    MineField_Found.Add(mine);
                    for (int i =0; i<MineField_Found.Count; i++)
                    {
                        Mines item = MineField_Found[i];
                        if(item != null)
                        {
                            if(item.Check_==false && item.IsThereMines == false)
                            {
                                Button bttn = (Button)panel1.Controls.Find(item.GetLocation.X + "" + item.GetLocation.Y, false)[0];
                                if(MinesAreAround(MineField_Found[i]) == 0)
                                {
                                    bttn.Enabled = false;
                                    AddSurrounding(item);
                                }
                                else
                                {
                                     bttn.Text = MinesAreAround(item).ToString();
                                }

                                ClearField++;
                                item.Check_ = true;
                            }
                        }
                    }
                }
                else
                {
                    btn.Text = Convert.ToString(numb);
                    ClearField++;
                }
            }

            if(ClearField >= mField.totatSphere - mField.totalMines)
            {
                TimerCountDown.Stop();
                button2.BackgroundImage = VictoryImage;
                button2.BackgroundImageLayout = ImageLayout.Stretch;
                MessageBox.Show("You win!!!");
                //DemonstareteMines();
                DialogResult dr = MessageBox.Show("Do you want to play again?", "You win", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    panel1.Controls.Clear();
                    NumberMines = 20;
                    New_start_game();
                }
                else
                {
                    this.Close();
                }
                
            }

        }

        public int  MinesAreAround(Mines m)       //How many mines are around (Etrafta kaç mayin var)
        {
            int Num = 0;

            if (m.GetLocation.X > 0)
            {
                if (mField.Mines_by_Location(new Point(m.GetLocation.X - 20, m.GetLocation.Y)).IsThereMines)
                {
                    Num++;
                }
            }

            if(m.GetLocation.Y < (panel1.Height-20) && m.GetLocation.X<panel1.Width-20)
            {
                if (mField.Mines_by_Location(new Point(m.GetLocation.X + 20, m.GetLocation.Y +20 )).IsThereMines)
                {
                    Num++;
                }
            }

            if(m.GetLocation.X < panel1.Width-20)
            {
                 if (mField.Mines_by_Location(new Point(m.GetLocation.X + 20, m.GetLocation.Y)).IsThereMines)
                {
                    Num++;
                }
            }

            if(m.GetLocation.X > 0 && m.GetLocation.Y>0)
                {
                if (mField.Mines_by_Location(new Point(m.GetLocation.X-20 , m.GetLocation.Y - 20)).IsThereMines)
                {
                    Num++;
                }
            }
            if(m.GetLocation.Y >0)
            { 
                if (mField.Mines_by_Location(new Point(m.GetLocation.X, m.GetLocation.Y -20)).IsThereMines)
                {
                    Num++;
                }
            }
            if(m.GetLocation.X >0 && m.GetLocation.Y<panel1.Height-20)
            {
                if (mField.Mines_by_Location(new Point(m.GetLocation.X - 20, m.GetLocation.Y + 20)).IsThereMines)
                {
                    Num++;
                }
            }

            if(m.GetLocation.Y < panel1.Height-20)
            {
                if (mField.Mines_by_Location(new Point(m.GetLocation.X, m.GetLocation.Y + 20)).IsThereMines)
                {
                    Num++;
                }
            }

            if (m.GetLocation.X > panel1.Width-20 && m.GetLocation.Y > 0)
            {
                if (mField.Mines_by_Location(new Point(m.GetLocation.X + 20, m.GetLocation.Y - 20)).IsThereMines)
                {
                    Num++;
                }
            }

            return Num;
        }
        public void DemonstareteMines()
        {
            foreach (var item in mField.GetAllMines)
            {
                if (item.IsThereMines)
                {
                   Button btn = (Button)panel1.Controls.Find(item.GetLocation.X +"" + item.GetLocation.Y,false)[0];
                    btn.BackgroundImage = MineImage;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }


        public void AddSurrounding(Mines m)
        {
            bool control1 = false;
            bool control2 = false;
            bool control3 = false;
            bool control4 = false;


            if(m.GetLocation.X>0)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X - 20 ,m.GetLocation.Y)));
                control1 = true;
            }

            if (m.GetLocation.Y>0)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X, m.GetLocation.Y-20)));
                control2 = true;
            }

            if (m.GetLocation.X < panel1.Width)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X + 20, m.GetLocation.Y)));
                control3 = true;
            }

            if (m.GetLocation.Y < panel1.Height)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X , m.GetLocation.Y+20)));
                control4 = true;
            }

            if(control1 && control2)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X - 20, m.GetLocation.Y - 20)));
            }
            if(control1 && control4)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X - 20, m.GetLocation.Y + 20)));
            }
            if (control2 && control3)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X + 20, m.GetLocation.Y - 20)));
            }
            if (control2 && control4)
            {
                MineField_Found.Add(mField.Mines_by_Location(new Point(m.GetLocation.X + 20, m.GetLocation.Y + 20)));
            }

        }

        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            LabelTimeLeft.Text = "Time Left: " + (--timeLeft).ToString();
            if(timeLeft == 0)
            {
                TimerCountDown.Stop();
                DialogResult dr = MessageBox.Show("Do you want to play again?", "Time is over", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    New_start_game();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerCountDown.Stop();
            panel1.Controls.Clear();
            New_start_game();
        }

        private void ScreenShotBtn_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(MyPanel.Width, MyPanel.Height))
            {
                MyPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"ScreenShots/" +"Minefield" + ".bmp");
            }
        }
    }
}
