using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AX_source_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }




            if (int.TryParse(textBoxAX.Text, out int number))
            {
                if (number <= 65536)
                {
                    textBoxAX.Text = number.ToString();
                }
                else
                {
                    textBoxAX.Text = "65536";
                }
            }
        }

        private void textBoxBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }




            if (int.TryParse(textBoxBX.Text, out int number))
            {
                if (number <= 65536)
                {
                    textBoxBX.Text = number.ToString();
                }
                else
                {
                    textBoxBX.Text = "65536";
                }
            }
        }

        private void textBoxCX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }




            if (int.TryParse(textBoxCX.Text, out int number))
            {
                if (number <= 65536)
                {
                    textBoxCX.Text = number.ToString();
                }
                else
                {
                    textBoxCX.Text = "65536";
                }
            }
        }

        private void textBoxDX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }




            if (int.TryParse(textBoxDX.Text, out int number))
            {
                if (number <= 65536)
                {
                    textBoxDX.Text = number.ToString();
                }
                else
                {
                    textBoxDX.Text = "65536";
                }
            }
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            //AX source
            if (AX_source.Checked && BX_destination.Checked)
            {
                (textBoxAX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxAX.Text);
            }
            if (AX_source.Checked && CX_destination.Checked)
            {
                (textBoxAX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxAX.Text);
            }

            if (AX_source.Checked && DX_destination.Checked)
            {
                (textBoxAX.Text, textBoxDX.Text) = (textBoxDX.Text, textBoxAX.Text);
            }

            //BX source
            if (BX_source.Checked && AX_destination.Checked)
            {
                (textBoxBX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxBX.Text);
            }

            if (BX_source.Checked && CX_destination.Checked)
            {
                (textBoxBX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxBX.Text);
            }

            if (BX_source.Checked && DX_destination.Checked)
            {
                (textBoxBX.Text, textBoxDX.Text) = (textBoxDX.Text, textBoxBX.Text);
            }

            //CX source
            if (CX_source.Checked && AX_destination.Checked)
            {
                (textBoxCX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxCX.Text);
            }

            if (CX_source.Checked && BX_destination.Checked)
            {
                (textBoxCX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxCX.Text);
            }

            if (CX_source.Checked && DX_destination.Checked)
            {
                (textBoxCX.Text, textBoxDX.Text) = (textBoxDX.Text, textBoxCX.Text);
            }

            //DX source
            if (DX_source.Checked && AX_destination.Checked)
            {
                (textBoxDX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxDX.Text);
            }

            if (DX_source.Checked && BX_destination.Checked)
            {
                (textBoxDX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxDX.Text);
            }

            if (DX_source.Checked && CX_destination.Checked)
            {
                (textBoxDX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxDX.Text);
            }

            
            //AX source
            //if (AX_source.Checked && BX_destination.Checked || BX_source.Checked && AX_destination.Checked)
            //{
            //    (textBoxAX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxAX.Text);
            //}
            //else if (AX_source.Checked && CX_destination.Checked || CX_source.Checked && AX_destination.Checked)
            //{
            //    (textBoxAX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxAX.Text);
            //}
            //else if (AX_source.Checked && DX_destination.Checked || DX_source.Checked && AX_destination.Checked)
            //{
            //    (textBoxAX.Text, textBoxDX.Text) = (textBoxDX.Text, textBoxAX.Text);
            //}
            //BX source
            //if (BX_source.Checked && AX_destination.Checked || AX_source.Checked && BX_destination.Checked)
            //{
            //    (textBoxBX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxBX.Text);
            //}
            //else if (BX_source.Checked && CX_destination.Checked || CX_source.Checked && BX_destination.Checked)
            //{
            //    (textBoxBX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxBX.Text);
            //}
            //else if (BX_source.Checked && DX_destination.Checked || DX_source.Checked && BX_destination.Checked)
            //{
            //    (textBoxBX.Text, textBoxDX.Text) = (textBoxDX.Text, textBoxBX.Text);
            //}
            //CX source
            //if (CX_source.Checked && BX_destination.Checked || BX_source.Checked && CX_destination.Checked)
            //{
            //    (textBoxCX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxBX.Text);
            //}
            //else if (CX_source.Checked && AX_destination.Checked || AX_source.Checked && CX_destination.Checked)
            //{
            //    (textBoxCX.Text, textBoxAX.Text) = (textBoxCX.Text, textBoxAX.Text);
            //}
            //else if (CX_source.Checked && DX_destination.Checked || DX_source.Checked && CX_destination.Checked)
            //{
            //    (textBoxCX.Text, textBoxDX.Text) = (textBoxDX.Text, textBoxCX.Text);
            //}
            //DX source
            //if (DX_source.Checked && AX_destination.Checked || AX_source.Checked && DX_destination.Checked)
            //{
            //    (textBoxDX.Text, textBoxAX.Text) = (textBoxAX.Text, textBoxDX.Text);
            //}
            //else if (DX_source.Checked && BX_destination.Checked || BX_source.Checked && DX_destination.Checked)
            //{
            //    (textBoxDX.Text, textBoxBX.Text) = (textBoxBX.Text, textBoxDX.Text);
            //}
            //else if (DX_source.Checked && CX_destination.Checked || CX_source.Checked && DX_destination.Checked)
            //{
            //    (textBoxDX.Text, textBoxCX.Text) = (textBoxCX.Text, textBoxDX.Text);
            //}
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBoxAX.Clear();
            textBoxBX.Clear();
            textBoxCX.Clear();
            textBoxDX.Clear();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AX
            if(AXmove.Checked && BXmove1.Checked){
                textBoxBX.Text = textBoxAX.Text;
            }

            if (AXmove.Checked && CXmove1.Checked)
            {
                textBoxCX.Text = textBoxAX.Text;
            }

            if (AXmove.Checked && DXmove1.Checked)
            {
                textBoxDX.Text = textBoxAX.Text;
            }

            //BX
            if (BXmove.Checked && AXmove1.Checked)
            {
                textBoxAX.Text = textBoxBX.Text;
            }

            if (BXmove.Checked && CXmove1.Checked)
            {
                textBoxCX.Text = textBoxBX.Text;
            }

            if (BXmove.Checked && DXmove1.Checked)
            {
                textBoxDX.Text = textBoxBX.Text;
            }

            //CX
            if (CXmove.Checked && AXmove1.Checked)
            {
                textBoxAX.Text = textBoxCX.Text;
            }

            if (CXmove.Checked && BXmove1.Checked)
            {
                textBoxBX.Text = textBoxCX.Text;
            }

            if (CXmove.Checked && DXmove1.Checked)
            {
                textBoxDX.Text = textBoxCX.Text;
            }

            //DX
            if (DXmove.Checked && AXmove1.Checked)
            {
                textBoxAX.Text = textBoxDX.Text;
            }

            if (DXmove.Checked && BXmove1.Checked)
            {
                textBoxBX.Text = textBoxDX.Text;
            }

            if (DXmove.Checked && CXmove1.Checked)
            {
                textBoxCX.Text = textBoxDX.Text;
            }

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }
    }
}
