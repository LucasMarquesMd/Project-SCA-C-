using System;
using System.Collections.Generic;
using System.Data;
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

        public DataSet returnDataSet(string sql)//Retorna um DataSet, de acordo com a consulta informada
        {
            try
            {
                openConnetion();
                //using -> garante que os recursos nao utilizados sejam descartados corretamente (independente de lancamento de excessoes)
                using (OleDbDataAdapter oDa = new OleDbDataAdapter(sql, myConnetion))
                {
                    DataSet oDs = new DataSet();
                    oDa.Fill(oDs);
                    return oDs;
                }
               
            }catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                throw;
            }
            finally
            {
                closeConnetion();
            }
        }
    }

    
}
