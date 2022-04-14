using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button[,] dokmeha;
        int plv;
        public Form1()
        {
            InitializeComponent();

            dokmeha = new Button[3, 3] { { button1,button2,button3},
                                         {button4,button5,button6 },
                                         {button7,button8,button9 }};
            new_game();


                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text =="")
            {
                if (plv==1)
                {
                    this_button.Text = "X";
                    this_button.BackColor = Color.Blue;
                    this_button.ForeColor = Color.DarkBlue;
                    plv = 2;

                }
                else if (plv==2)
                {
                    this_button.Text = "O";
                    this_button.BackColor = Color.Black;
                    this_button.ForeColor = Color.Gray;
                    plv =1;
                }
                chek_game();
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           // Button this_button = (sender as Button);
           // this_button.BackColor = Color.Green;

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //Button this_button = (sender as Button);
           // this_button.BackColor = Color.Indigo;
        }


        private void new_game()
        {
            plv = 1;
            for(int i=0;i<3;i++)
            {
                for (int j=0; j<3; j++)
                {
                    dokmeha[i, j].Text = "";
                    dokmeha[i, j].BackColor = Color.Beige;

                }
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            new_game();
        }

        private void chek_game()
        {

            if (dokmeha[0, 0].Text == "X" && dokmeha[0, 1].Text == "X" && dokmeha[0, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 0].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 1].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 2].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن اول برنده شد");
                new_game();
            }


            if (dokmeha[0, 0].Text == "O" && dokmeha[0, 1].Text == "O" && dokmeha[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 0].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 1].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 2].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن دوم برنده شد");
                new_game();
            }
            else if (dokmeha[0, 0].Text != "" && dokmeha[0, 1].Text != "" && dokmeha[0, 2].Text != "" && dokmeha[1, 0].Text != "" && dokmeha[1, 1].Text != "" && dokmeha[1, 2].Text != "" && dokmeha[2, 0].Text != "" && dokmeha[2, 1].Text != "" && dokmeha[2, 2].Text != "")
            {
                MessageBox.Show("هر دو بازیکن مساوی شدن");
                new_game();
            }
        }
    }
}
