using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyboardHookDLL;
using MouseHookDLL;


namespace Lab_KeyboardHook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyboardHook.KeyPressed += KeyboardHook_KeyPressed;
            MouseHook.MouseClicked += MouseHook_MouseClicked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            KeyboardHook.Start();
            textBox1.AppendText("WH_KEYBOARD started." + Environment.NewLine);

            MouseHook.Start();
            textBox2.AppendText("WH_MOUSE started." + Environment.NewLine);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            KeyboardHook.Stop();
            textBox1.Clear();
            textBox1.AppendText("WH_KEYBOARD stopped." + Environment.NewLine);

            MouseHook.Stop();
            textBox2.Clear();
            textBox2.AppendText("WH_MOUSE stopped." + Environment.NewLine);
        }

        private void KeyboardHook_KeyPressed(object sender, KeyboardHook.KeyEventArgs e)
        {
            textBox1.AppendText(e.Key.ToString() + Environment.NewLine);
        }

        private void MouseHook_MouseClicked(object sender, MouseHook.MouseEventArgs e)
        {
            textBox2.Invoke((MethodInvoker)delegate
            {
                textBox2.AppendText($"X: {e.X}, Y: {e.Y}" + Environment.NewLine);
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
