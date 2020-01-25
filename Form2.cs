using SnakeGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hardButton.Checked) {
                Settings.Speed = 20;
            }
            else if (mediumButton.Checked)
            {
                Settings.Speed = 15;
              
            }
            else if(easyButton.Checked){
                Settings.Speed = 8;
            }

            if (nicknamebox.TextLength > 0) {
                Settings.Nickname = nicknamebox.Text;
                var f1 = new Form1();
                f1.ShowDialog();
            }
            else {
                MessageBox.Show("Check your Nickname", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
