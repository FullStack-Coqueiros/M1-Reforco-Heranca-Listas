using Heranca;


List<Pessoa> listaDePessoas = new List<Pessoa>();

Heranca.Pessoa pessoa1 = new Heranca.Pessoa();

listaDePessoas.Add(pessoa1);

Pessoa pessoa2 = new Pessoa("Vitor");
listaDePessoas.Add(pessoa2);


Pessoa pessoa3 = new Pessoa("Marcelo", "123", "Email");
listaDePessoas.Add(pessoa3);

Medico medico = new Medico();
medico.CRM = "56";
medico.Email = "dssa";

Medico medico1 = new Medico("546", "Clinico");

Medico medico2 = new Medico("Marcos","4566","Marcos@", "54652", "Oftalmo");

///Trabalhado com listas 
Pessoa pessoa3ObtidaDaLista = listaDePessoas[2];

Console.WriteLine(pessoa3ObtidaDaLista.Nome);
Console.WriteLine(listaDePessoas[2].Nome);

Pessoa pessoaVitorBuscadaNaLista = listaDePessoas.Find(people => people.Nome == "Vitor");
//Resultado igual a busca por find 
Pessoa pessoaVitorBuscadaNaListaForEach; 
foreach(var people in listaDePessoas){
  if(people.Nome == "Vitor")
  {
    pessoaVitorBuscadaNaListaForEach = people;
  }
}

List<Pessoa> pessoasQueNaoVitorBuscadaNaLista = listaDePessoas.Where(pessoa => pessoa.Nome != "Vitor").ToList();

foreach(var people in listaDePessoas){
  Console.WriteLine(people.Nome);
}



Console.WriteLine("Sair");