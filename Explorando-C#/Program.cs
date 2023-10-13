using Explorando_C_.Models;

Pessoa p1 = new Pessoa(nome: "Roberto", sobrenome: "Conrado");
Pessoa p2 = new Pessoa(nome: "Jose", sobrenome: "Rocha");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Ingles";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();














// Pessoa p1 = new Pessoa();
// p1.Nome = "Roberto";
// p1.Sobrenome = "Conrado";
// p1.Idade = 29;
// p1.Apresentar();