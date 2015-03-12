using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Encrypt(textBox1.Text,richTextBox1.Text);

        }
        private string Encrypt(string pass, string messageToEncrypt)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < messageToEncrypt.Length; i++)
            {
                var d = (pass[i % pass.Length] ^ messageToEncrypt[i]);
                sb.Append(d + ",");

            }
            return sb.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Decrypt(textBox1.Text,richTextBox2.Text.Split(','));

        }
        private string Decrypt(string pass, string[] messageToDecrypt)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < messageToDecrypt.Length; i++)
            {
                if (messageToDecrypt[i] != "")
                {
                    var d = (pass[i % pass.Length] ^ int.Parse(messageToDecrypt[i]));
                    sb.Append((char)d);

                }
            }
            return sb.ToString();

        }

    }
}
