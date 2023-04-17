using PESSOA;

internal class Program {
    private static void Main(string[] args) {

        //Instanciando e Chamento classe Pai
        Console.Write("Instancie uma Pessoa: \n\nNome: ");
        string nome = Console.ReadLine();

        Console.Write("Rg: ");
        string rg = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Console.Write("Data de Nascimento: ");
        DateTime nasc = DateTime.Parse(Console.ReadLine());

        //Instaciando Pessoa e chamando Metodo
        Pessoa p = new Pessoa(nome, rg, cpf, nasc);
        Console.WriteLine("Pessoa Instanceada");
        Console.WriteLine(p.Identificacao());

        //Instanciando Aluno e chamando metodo Herdado
        Console.Write("Instancie um Aluno: \n\nRA: ");
        string ra = Console.ReadLine();

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Console.Write("Mensalidade: R$ ");
        double mensalidade = double.Parse(Console.ReadLine());

        //Instanciando e chamando Metodo
        Pessoa a = new Aluno(ra, curso, mensalidade);
        Console.WriteLine("Aluno Instanciado \n");
        Console.WriteLine(a.Identificacao());

        //Instanciando Professor e chamando metodo Herdado
        Console.Write("Instancie um Professor: \n\nFuncional: ");
        string funcional = Console.ReadLine();

        Console.Write("Disciplina: ");
        string disciplina = Console.ReadLine();

        Console.Write("Salario: R$ ");
        double salario = double.Parse(Console.ReadLine());

        //Instanciando e chamando Metodo
        Pessoa prof = new Professor(funcional, disciplina, salario);
        Console.WriteLine("Professor Instanciado \n");
        Console.WriteLine(a.Identificacao());

        //Fim do Programa
        Console.WriteLine("Fim do Programa");
    }
}