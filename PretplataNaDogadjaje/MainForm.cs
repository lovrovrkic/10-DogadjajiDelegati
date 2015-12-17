using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonDelete.Click += ButtonDelete_Click;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = textBox.TextLength > 0;
        }

        // Dodati metodu za obradu događaja (event handler) koji će onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti kada je neki tekst upisan.


        // Dodati metodu za obradu događaja koji će na pritisak tipke buttonDelete obrisati sadržaj kontrole textBox.
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            textBox.Text = "";  //string.Empty;
        }

        // Dodati metodu za obradu događaja koji će na pritisak tipke buttonClose zatvoriti formu.
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
