namespace PESSOA {
    public class Pessoa {
        private string Nome { get; set; }
        private string Rg { get; set; }
        private string Cpf { get; set; }
        private DateTime Nasc { get; set; }

        //Construtores
        public Pessoa() {

        }

        public Pessoa(string nome, string rg, string cpf, DateTime nasc) {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Nasc = nasc;
        }

        //Function
        public virtual string Identificacao() {
            return Cpf;
        }
    }

    public class Professor : Pessoa {
        public string Funcional { get; private set; }
        public string Disciplina { get; private set; }
        public double Salario { get; private set; }

        //Contrutores
        public Professor(string func, string curso, double valor) : base() { 
            Funcional = func;
            Disciplina = curso;
            Salario = valor;
        }

        //Override
        public override string Identificacao() {
            return Funcional;
        }
    }

    public class Aluno : Pessoa {
        public string Ra { get; private set; }
        public string Curso { get; private set; }
        public double Mensalidade { get; private set; }

        //Contrutor
        public Aluno(string ra, string curso, double valor) : base() {
            Ra = ra;
            Curso = curso;
            Mensalidade = valor;
        }

        //Override
        public override string Identificacao() {
            return Ra;
        }
    }
}