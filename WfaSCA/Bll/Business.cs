using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bll
{
    public class Business
    {

        public DataSet findAllAlunos()
        {
            conOleDb acessoDados = new conOleDb();
            return acessoDados.returnDataSet("SELECT * FROM Alunos");
        }
    }
}
