using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobDamageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Defines base variables
            decimal attackRoll = 0;
            decimal armorClass = 0;
            decimal numberOfCreatures = 0;

            try
            {
                //Gets decimal information from String input
                attackRoll = Convert.ToDecimal(txtAttackRoll.Text);
                armorClass = Convert.ToDecimal(txtAC.Text);
                numberOfCreatures = Convert.ToDecimal(txtNumCreatures.Text);
            } catch (FormatException){
                MessageBox.Show("Invalid Input, Please try again.");
            }

            //Calculates the d20 roll needed to hit target
            decimal d20Needed = armorClass - attackRoll;
            if(d20Needed > 20)
            {
                d20Needed = 20;
            }else if (d20Needed < 1)
            {
                d20Needed = 1;
            }

            decimal creaturesThatHit = 0;

            //Calculates the minimum number of creatures needed to hit a target
            if (d20Needed >= 1 && d20Needed <= 5)
            {
                creaturesThatHit = 1;
            }
            else if (d20Needed >= 6 && d20Needed <= 12)
            {
                creaturesThatHit = 2;
            }
            else if (d20Needed >= 13 && d20Needed <= 14)
            {
                creaturesThatHit = 3;
            }
            else if (d20Needed >= 15 && d20Needed <= 16)
            {
                creaturesThatHit = 4;
            }
            else if (d20Needed >= 17 && d20Needed <= 18)
            {
                creaturesThatHit = 5;
            }
            else if (d20Needed == 19)
            {
                creaturesThatHit = 10;
            }
            else if (d20Needed == 20)
            {
                creaturesThatHit = 20;
            }

            //Displays the minimum number of creatures required to hit once
            txtMinNeededToHit.Text = creaturesThatHit.ToString("n0");

            //Displays the number of creatures that hit, given the minimun required, rounded down 
            decimal numberOfHits = Math.Floor(numberOfCreatures / creaturesThatHit);
            txtCreaturesThatHit.Text = numberOfHits.ToString("n0");

            //-----------------------------------Generates random numbers based on entered data
            try
            {
                Random rnd = new Random();
                int attackMod = Int32.Parse(txtAttackMod.Text);
                int totalDamage;
                double averageDamage;

                int d4 = 0;
                for (int i = 0; i < Int32.Parse(txtD4.Text); i++)
                {
                    d4 = d4 += rnd.Next(1, 5);
                }

                int d6 = 0;
                for (int i = 0; i < Int32.Parse(txtD6.Text); i++)
                {
                    d6 = d6 += rnd.Next(1, 7);
                }

                int d8 = 0;
                for (int i = 0; i < Int32.Parse(txtD8.Text); i++)
                {
                    d8 = d8 += rnd.Next(1, 9);
                }

                int d10 = 0;
                for (int i = 0; i < Int32.Parse(txtD10.Text); i++)
                {
                    d10 = d10 += rnd.Next(1, 11);
                }

                int d12 = 0;
                for (int i = 0; i < Int32.Parse(txtD12.Text); i++)
                {
                    d12 = d12 += rnd.Next(1, 13);
                }

                averageDamage = Math.Floor(attackMod + (3.5 * Int32.Parse(txtD6.Text) + (4.5 * Int32.Parse(txtD8.Text))));
                txtAverageDamage.Text = averageDamage.ToString("n0");

                totalDamage = attackMod + d4 + d6 + d8 + d10 + d12;
                txtTotalDamage.Text = totalDamage.ToString("n0");
            } catch (FormatException)
            {
                MessageBox.Show("Invalid Input, Please try again.");
            }
            
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears input and output fields
            txtAttackRoll.Text = "0";
            txtAC.Text = "0";
            txtNumCreatures.Text = "0";
            txtMinNeededToHit.Text = "0";
            txtCreaturesThatHit.Text = "0";
            txtAttackRoll.Text = "0";
            txtD4.Text = "0";
            txtD6.Text = "0";
            txtD8.Text = "0";
            txtD10.Text = "0";
            txtD12.Text = "0";
            txtTotalDamage.Text = "0";
            txtAverageDamage.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes window
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
