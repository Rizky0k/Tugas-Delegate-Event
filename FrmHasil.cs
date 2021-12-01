using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasDelegate
{
    public partial class FrmHasil : Form
    {
        private IList<Hitung> listOfHitung = new List<Hitung>();
        public FrmHasil()
        {
            InitializeComponent();
            Inisialisasiawal();
        }
        private void Inisialisasiawal()
        {
            listHasil.Items.Clear();
        }
        private void FrmHitung_OnProses(Hitung htg)
        {
            //listOfHitung.Add(htg);
            // ListViewItem item = new ListViewItem();
            //lvwHasil.Items.Add(htg.operasi);
            listHasil.Items.Add(htg.operasi);
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            FrmHitung frmHitung = new FrmHitung("Calculator");

            frmHitung.OnProses += FrmHitung_OnProses;

            frmHitung.ShowDialog();
        }
    }
}
