using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Alunos
    {
        private string alu_Mat { get; set; }
        private string alu_nome { get; set; }
        private string alu_ing { get; set; }
        private DateTime alu_dta_nasc { get; set; }
        private string alu_CPF { get; set; }
        private string alu_Sexo { get; set; }
        private string alu_Email { get; set; }
        private string alu_End_Cep { get; set; }
        private string alu_End_Log { get; set; }
        private string alu_End { get; set; }
        private int alu_Nro { get; set; }
        private string alu_End_cpl { get; set; }
        private string alu_En_Bai { get; set; }
        private string alu_End_Cid { get; set; }


        //Dependencias
        private Estados estado;
        private Cursos curso;
    }
}
