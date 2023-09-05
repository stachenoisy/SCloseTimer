using System.Runtime.InteropServices;
using System.Security.Policy;
using System.IO;
using System.Windows;

namespace SCloseTimer
{
    public partial class Form1 : Form
    {
        int sn, dk, st, sure;

        public Form1()
        {
            InitializeComponent();

            Color myColor = System.Drawing.ColorTranslator.FromHtml("#181818");
            Color myColor2 = System.Drawing.ColorTranslator.FromHtml("#FD0303");

            /*this.BackColor = myColor;*/
            this.TransparencyKey = Color.Black;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;

        }
        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Form1.ActiveForm.Location = new Point(
                    (Form1.ActiveForm.Location.X - lastLocation.X) + e.X, (Form1.ActiveForm.Location.Y - lastLocation.Y) + e.Y);

                Form1.ActiveForm.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                timer1.Enabled = false;
                System.Diagnostics.Process.Start("shutdown", "-a");
            }



            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sn = Convert.ToInt32(textBox3.Text.ToString());
            dk = Convert.ToInt32(textBox2.Text.ToString());
            st = Convert.ToInt32(textBox1.Text.ToString());
            sure = sn + (dk * 60) + ((st * 60) * 60);
            System.Diagnostics.Process.Start("shutdown", "-s -t " + sure + " -f");
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                System.Diagnostics.Process.Start("shutdown", "-a");
                timer1.Stop();
                timer1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Zamanlayýcý çalýþmýyor.", "Oh! Hayýr.");
            }

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sn < 1)
            {
                sn = 59;
                if (dk == 0)
                {
                    dk = 59;
                    if (st != 0)
                    {
                        st -= 1;
                    }
                }
                else
                {
                    dk -= 1;
                }
            }
            else
            {
                sn -= 1;
            }

            textBox1.Text = st.ToString();
            textBox2.Text = dk.ToString();
            textBox3.Text = sn.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                textBox1.Text = "0";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                textBox2.Text = "0";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                textBox3.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 2)
            {
                textBox1.Text = "24";
            }

            if (Convert.ToInt32(textBox1.Text.ToString()) > 24)
            {
                textBox1.Text = "24";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 2)
            {
                textBox2.Text = "59";
            }

            if (Convert.ToInt32(textBox2.Text.ToString()) > 59)
            {
                textBox2.Text = "59";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 2)
            {
                textBox3.Text = "59";
            }

            if (Convert.ToInt32(textBox3.Text.ToString()) > 59)
            {
                textBox3.Text = "59";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}