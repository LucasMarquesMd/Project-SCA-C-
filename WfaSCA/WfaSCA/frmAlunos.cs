using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;

namespace WfaSCA
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            initializeListView();
        }

        public void initializeListView()
        {
            Business business = new Business();
            DataSet dta = business.findAllAlunos();


        }
    }
}
