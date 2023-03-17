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
            Random randomNum = new Random();
            int rand;
            bool isCorrect = false;
        public Form1()
        {
            InitializeComponent();
            checkCorrect.Text = "";
            rand =  randomNum.Next(1, 100);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
            {
                
                    if (int.Parse(input.Text) < rand)
                    {
                        checkCorrect.Text = "არასწორია, სცადე უფრო დიდი რიცხვი";
                    }
                    else if (int.Parse(input.Text) > rand)
                    {
                        checkCorrect.Text = "არასწორია, სცადე უფრო პატარა რიცხვი";
                    }
                    else
                    {
                        isCorrect = true;
                        checkCorrect.Text = $"სწორია, პასუხი იყო {rand} {isCorrect}";
                    }
                
            }
            else
            {
                return;
            }
            if (isCorrect)
            {
                button1.Visible = true;
                enterBtn.Enabled = false;
            }
            
            
        }
       

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void paragraph2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isCorrect = false;
            button1.Visible = false;
            enterBtn.Enabled = true;
            rand = randomNum.Next(1, 100);
            checkCorrect.Text = "";
            input.Text = "";
        }

        private void warning_Click(object sender, EventArgs e)
        {

        }
    }
}
