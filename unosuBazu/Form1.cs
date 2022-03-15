using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unosuBazu.ModelBaze;

namespace unosuBazu
{
    
    public partial class Form1 : Form
    {
        List<Ucenici> ljudi = new List<Ucenici>();
        public Form1()
        {
            InitializeComponent();
            Upisani.DataSource = ljudi;
        }
        private void Update1()
        {
            Upisani.DataSource = ljudi;
            Upisani.DisplayMember = "Info";
        }

        

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            db.unosUbazu(unosIme.Text, unosPrezime.Text);
            unosPrezime.Text = null;
            unosIme.Text = null;

        }

        private void Pregled_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            ljudi = db.ispis();
            Update1();

        }

        private void Pretrazi_Click(object sender, EventArgs e)
        {
            PristupBazi db=new PristupBazi();
            ljudi = db.trazi(TraziIme.Text);
            Update1();
        }
    }
}
