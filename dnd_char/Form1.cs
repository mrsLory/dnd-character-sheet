using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_char

{
    public partial class Form1 : Form
    {
        public class Character
        {
            public int[] racepoint;
            public int speed;
            public int dhp;
            public int[] spasBroski;

            public string characterRace;
            public string characterClass;

            public Character(string chRace, string chClass)
            {
               
                {
                    racepoint = new int[6] { 0, 0, 0, 0, 0, 0 };
                    spasBroski = new int[6] { 0, 0, 0, 0, 0, 0 };

                    this.characterRace = chRace;
                    this.characterClass = chClass;

                    switch (chRace)
                    {
                        case "Дварф":
                            racepoint[2] += 2;
                            speed = 25;
                            break;
                        case "Эльф":
                            racepoint[1] += 2;
                            speed = 30;
                            break;
                    }

                    switch (chClass)
                    {
                        case "Волшебник":
                            spasBroski[3] = 1;
                            spasBroski[4] = 1;
                            dhp = 6;
                            break;
                        case "Паладин":
                            spasBroski[4] = 1;
                            spasBroski[5] = 1;
                            dhp = 10;
                            break;
                    }

                }
            }
        }


        int[] lastznach = new int[6] { 8, 8, 8, 8, 8, 8 };
        int svobodnOchkie = 21;
        Character character;

        public Form1()
        {
            InitializeComponent();
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 8;
            numericUpDown1.Maximum = 15;
            numericUpDown1.Minimum = 8;

            numericUpDown2.Value = 8;
            numericUpDown2.Maximum = 15;
            numericUpDown2.Minimum = 8;

            numericUpDown3.Value = 8;
            numericUpDown3.Maximum = 15;
            numericUpDown3.Minimum = 8;

            numericUpDown4.Value = 8;
            numericUpDown4.Maximum = 15;
            numericUpDown4.Minimum = 8;

            numericUpDown5.Value = 8;
            numericUpDown5.Maximum = 15;
            numericUpDown5.Minimum = 8;

            numericUpDown6.Value = 8;
            numericUpDown6.Maximum = 15;
            numericUpDown6.Minimum = 8;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((svobodnOchkie != 0) || (Convert.ToInt32(numericUpDown1.Value) - lastznach[0] < 0))
            {
                svobodnOchkie -= (Convert.ToInt32(numericUpDown1.Value) - lastznach[0]);
                lastznach[0] = Convert.ToInt32(numericUpDown1.Value);
            }

            else
            {

                MessageBox.Show("Доступные очки характеристик персонажа закончились, уменьшите значения других характеристик чтобы повысить эту");
                numericUpDown1.Value = lastznach[0];
            }
            label1.Text = Math.Round(((numericUpDown1.Value-10)/2), MidpointRounding.ToNegativeInfinity).ToString("+#;-#;0");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if ((svobodnOchkie != 0) || (Convert.ToInt32(numericUpDown2.Value) - lastznach[1] < 0))
            {
                svobodnOchkie -= (Convert.ToInt32(numericUpDown2.Value) - lastznach[1]);
                lastznach[1] = Convert.ToInt32(numericUpDown2.Value);
            }
            else
            {

                MessageBox.Show("Доступные очки характеристик персонажа закончились, уменьшите значения других характеристик чтобы повысить эту");
                numericUpDown2.Value = lastznach[1];
            }
            label2.Text = Math.Round(((numericUpDown2.Value - 10) / 2), MidpointRounding.ToNegativeInfinity).ToString("+#;-#;0");
            textBox1.Text = label2.Text;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if ((svobodnOchkie != 0) || (Convert.ToInt32(numericUpDown3.Value) - lastznach[2] < 0))
            {
                svobodnOchkie -= (Convert.ToInt32(numericUpDown3.Value) - lastznach[2]);
                lastznach[2] = Convert.ToInt32(numericUpDown3.Value);
            }
            else
            {

                MessageBox.Show("Доступные очки характеристик персонажа закончились, уменьшите значения других характеристик чтобы повысить эту");
                numericUpDown3.Value = lastznach[2];
            }
            label3.Text = Math.Round(((numericUpDown3.Value - 10) / 2), MidpointRounding.ToNegativeInfinity).ToString("+#;-#;0");
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if ((svobodnOchkie != 0) || (Convert.ToInt32(numericUpDown4.Value) - lastznach[3] < 0))
            {
                svobodnOchkie -= (Convert.ToInt32(numericUpDown4.Value) - lastznach[3]);

                lastznach[3] = Convert.ToInt32(numericUpDown4.Value);
            }
            else
            {

                MessageBox.Show("Доступные очки характеристик персонажа закончились, уменьшите значения других характеристик чтобы повысить эту");
                numericUpDown4.Value = lastznach[3];
            }
            label4.Text = Math.Round(((numericUpDown4.Value - 10) / 2), MidpointRounding.ToNegativeInfinity).ToString("+#;-#;0");
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if ((svobodnOchkie != 0) || (Convert.ToInt32(numericUpDown5.Value) - lastznach[4] < 0))
            {
                svobodnOchkie -= (Convert.ToInt32(numericUpDown5.Value) - lastznach[4]);
               
                lastznach[4] = Convert.ToInt32(numericUpDown5.Value);
            }
            else
            {

                MessageBox.Show("Доступные очки характеристик персонажа закончились, уменьшите значения других характеристик чтобы повысить эту");
                numericUpDown5.Value = lastznach[4];
            }
            label5.Text = Math.Round(((numericUpDown5.Value - 10) / 2), MidpointRounding.ToNegativeInfinity).ToString("+#;-#;0");
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if ((svobodnOchkie != 0) || (Convert.ToInt32(numericUpDown6.Value) - lastznach[5] < 0))
            {
                svobodnOchkie -= (Convert.ToInt32(numericUpDown6.Value) - lastznach[5]);
               
                lastznach[5] = Convert.ToInt32(numericUpDown6.Value);
            }
            else
            {

                MessageBox.Show("Доступные очки характеристик персонажа закончились, уменьшите значения других характеристик чтобы повысить эту");
                numericUpDown6.Value = lastznach[5];
            }
            label6.Text = Math.Round(((numericUpDown6.Value - 10) / 2), MidpointRounding.ToNegativeInfinity).ToString("+#;-#;0");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                lastznach = new int[6] { 8, 8, 8, 8, 8, 8 };
                numericUpDown1.Value = 8;
                numericUpDown2.Value = 8;
                numericUpDown3.Value = 8;
                numericUpDown4.Value = 8;
                numericUpDown5.Value = 8;
                numericUpDown6.Value = 8;
                svobodnOchkie = 21;

                character = new Character(comboBox1.Text, comboBox2.Text);
                numericUpDown1.Value += Convert.ToDecimal(character.racepoint[0]);
                svobodnOchkie += character.racepoint[0];
                numericUpDown2.Value += Convert.ToDecimal(character.racepoint[1]);
                svobodnOchkie += character.racepoint[1];
                numericUpDown3.Value += Convert.ToDecimal(character.racepoint[2]);
                svobodnOchkie += character.racepoint[2];
                numericUpDown4.Value += Convert.ToDecimal(character.racepoint[3]);
                svobodnOchkie += character.racepoint[3];
                numericUpDown5.Value += Convert.ToDecimal(character.racepoint[4]);
                svobodnOchkie += character.racepoint[4];
                numericUpDown6.Value += Convert.ToDecimal(character.racepoint[5]);
                svobodnOchkie += character.racepoint[5];
                textBox2.Text = character.speed.ToString();

                textBox4.Text = "k" + character.dhp.ToString();

                for (int i = 0; i < 6; i++)
                {
                    if (character.spasBroski[i] == 1) checkedListBox2.SetItemChecked(i, true);
                    else checkedListBox2.SetItemChecked(i, false);
                }
            } else
            {
                MessageBox.Show("Введите класс и расу персонажа");
            }
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
