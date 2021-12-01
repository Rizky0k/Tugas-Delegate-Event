using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasDelegate
{
    public partial class FrmHitung : Form
    {
        public delegate void CreateUpdateEventHandler(Hitung htg);
        public event CreateUpdateEventHandler OnProses;
        public FrmHitung()
        {
            InitializeComponent();
        }
        public FrmHitung(string title)
            : this()
        {
            this.Text = title;
        }

        private int penambahan(int a, int b)
        {
            return a + b;
        }
        private int pengurangan(int a, int b)
        {
            return a - b;
        }
        private int perkalian(int a, int b)
        {
            return a * b;
        }
        private int pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            int hasil;
            string operasi = "";


            if (cmbOperasi.SelectedIndex == 0)
            {
                hasil = penambahan(a, b);
                operasi = $"hasil penambahan : {a} + {b} = {hasil}";
            }
            if (cmbOperasi.SelectedIndex == 1)
            {
                hasil = pengurangan(a, b);
                operasi = $"hasil pengurangan : {a} - {b} = {hasil}";
            }
            if (cmbOperasi.SelectedIndex == 2)
            {
                hasil = perkalian(a, b);
                operasi = $"hasil perkalian : {a} x {b} = {hasil}";
            }
            if (cmbOperasi.SelectedIndex == 3)
            {
                hasil = pembagian(a, b);
                operasi = $"hasil pembagian : {a} / {b} = {hasil}";
            }
            var htg = new Hitung();
            htg.operasi = operasi.ToString();
            OnProses(htg);


        }
    }
}
