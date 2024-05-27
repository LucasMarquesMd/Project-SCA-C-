using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class conOleDb
    {
        OleDbConnection myConnetion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\lucas\OneDrive\Área de Trabalho\FATEC\4 Semestre\ILP580 - ASPNet\PROJETO\DB\sca.accdb");

        public void openConnetion()
        {
            myConnetion.Open();
        }

        public void closeConnetion()
        {
            myConnetion.Close();
        }
    }

    
}
