using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame_Simran
{
    public partial class Form1 : Form
    {
        int chk = 0;

        Running instanceRunning = new Running();
        Player instancePlayer = new Player();

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("First fill  the bet details like dog no and bet amount and then select the player from the checkbox");


             //calling the method of the static class to load the image of the runner 
            Dog.dog1(pictureBox1);
            Dog.dog2(pictureBox2);
            Dog.dog3(pictureBox3);
            Dog.dog4(pictureBox4);
         


        }

       

        private void Simran_CheckedChanged(object sender, EventArgs e)
        {
            //if the simran  choosed for the bet then we have to verfiy the rest things 
            if (Simran.Checked==true) {
                if (!DogSimran.Value.ToString().Equals("") && !BetSimran.Value.ToString().Equals("") && DogSimran.Value>0 && BetSimran.Value>0 && BetSimran.Value <= Convert.ToInt32(budgetSimran.Text.ToString()))
                {
                    chk=1;

                }
                else {
                    MessageBox.Show("Check your filling details once ");
                    Simran.Checked = false;
                }
            }

        }

        private void Priya_CheckedChanged(object sender, EventArgs e)
        {
            //if the Priya   choosed for the bet then we have to verfiy the rest things 
            if (Priya.Checked == true)
            {
                if (!DogPriya.Value.ToString().Equals("") && !BetPriya.Value.ToString().Equals("") && DogPriya.Value>0 && BetPriya.Value>0 && BetPriya.Value <= Convert.ToInt32(BudgetPriya.Text.ToString()))
                {
                    chk=2;
                }
                else
                {
                    MessageBox.Show("Check your filling details once ");
                    Priya.Checked = false;
                }
            }


        }

        private void Mannat_CheckedChanged(object sender, EventArgs e)
        {
            //if the Mannat  choosed for the bet then we have to verfiy the rest things 
            if (Mannat.Checked == true)
            {
                if (!DogMannat.Value.ToString().Equals("") && !BetMannat.Value.ToString().Equals("") && DogMannat.Value>0 && BetMannat.Value <= Convert.ToInt32(budgetMannat.Text.ToString()) && BetMannat.Value> 0  )
                {
                    chk=3;
                }
                else
                {
                    MessageBox.Show("Check your filling details once ");
                    Mannat.Checked = false;
                }
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            // call the method to move the from one position to another 
            int winer = 0;
            winer =instanceRunning.moveFirst(pictureBox1,timer1);
            if (winer!=1) {
                winer = instanceRunning.move2nd(pictureBox2, timer1);
                if (winer!=2) {
                    winer = instanceRunning.move3rd(pictureBox3, timer1);
                    if (winer!=3) {
                        winer = instanceRunning.move4th(pictureBox4, timer1);
                    }
                }
                
                

            }

            if (winer>0) {
                
                if (Simran.Checked==true) {
                    if (winer == DogSimran.Value)
                    {

                        budgetSimran.Text = "" + Simn.increment(Convert.ToInt32(budgetSimran.Text.ToString()), Convert.ToInt32(BetSimran.Value));

                      //  budgetSimran.Text = "" + instancePlayer.player1(budgetSimran, Convert.ToInt32(BetSimran.Value), Convert.ToInt32(DogSimran.Value), winer);
                    }
                    else {
                        budgetSimran.Text = "" + Simn.decrement(Convert.ToInt32(budgetSimran.Text.ToString()), Convert.ToInt32(BetSimran.Value));
                    //    budgetSimran.Text = "" + instancePlayer.player1(budgetSimran, Convert.ToInt32(BetSimran.Value), Convert.ToInt32(DogSimran.Value), winer);
                    }
                    
                }

                if (Priya.Checked == true)
                {
                    if (winer == BetPriya.Value)
                    {

                        BudgetPriya.Text = "" + Pri.increment(Convert.ToInt32(BudgetPriya.Text.ToString()), Convert.ToInt32(BetPriya.Value));
                    }
                    else {
                        BudgetPriya.Text = "" + Pri.deccrement(Convert.ToInt32(BudgetPriya.Text.ToString()), Convert.ToInt32(BetPriya.Value));
                    }
                   // BudgetPriya.Text = "" + instancePlayer.player2(BudgetPriya, Convert.ToInt32(BetPriya.Value), Convert.ToInt32(DogPriya.Value), winer);

                }

                if (Mannat.Checked == true)
                {
                    if (winer == BetMannat.Value)
                    {


                        budgetMannat.Text = "" + Man.increment(Convert.ToInt32(budgetMannat.Text.ToString()), Convert.ToInt32(BetMannat.Value));
                    }
                    else {
                        budgetMannat.Text = "" + Man.deccrement(Convert.ToInt32(budgetMannat.Text.ToString()), Convert.ToInt32(BetMannat.Value));
                    }
                    //budgetMannat.Text = "" + instancePlayer.player2(budgetMannat, Convert.ToInt32(BetMannat.Value), Convert.ToInt32(DogMannat.Value), winer);

                }

                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
                pictureBox4.Left = 0;

                Simran.Checked = false;
                Priya.Checked = false;
                Mannat.Checked = false;

                BetMannat.Value = 0;
                BetPriya.Value = 0;
                BetSimran.Value = 0;

                DogMannat.Value = 0;
                DogPriya.Value = 0;
                DogSimran.Value = 0;

                chk = 0;
                btnGo.Visible = false;
                lblPlayer1.Text = "";
                lblPlayer2.Text = "";
                lblPlayer3.Text = "";

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(chk.ToString());
            if (chk > 0)
            {
                if (chk == 1)
                {
                    lblPlayer1.Text = "Simran Choose " + DogSimran.Value + " and  set Bet Amount " + BetSimran.Value;
                }
                if (chk == 2)
                {
                    lblPlayer2.Text = "Priya Choose " + DogPriya.Value + " and set Bet Amount  " + BetPriya.Value;
                }
                if (chk == 3)
                {
                    lblPlayer3.Text = "Mannat Choose " + DogMannat.Value + " and Set Bet Amount " + BetMannat.Value;
                }

                btnGo.Visible = true;

            }
            else
            {
                MessageBox.Show("Set the bet details first ");
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
