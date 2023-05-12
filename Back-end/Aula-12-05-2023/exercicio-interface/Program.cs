using exercicio_interface;


List<Contato> contatos = new List<Contato>();

ContatoComercial contato_comercial = new ContatoComercial();
ContatoPessoal contato_pessoal = new ContatoPessoal();

Console.WriteLine(@$"
    ___________________________________________
   / Que tipo de Contato deseja adicionar?    /
  / [1] Contato Comercial                    /
 / [2] Contato Pessoal                      /
/__________________________________________/
");
char tipoContato = char.Parse(Console.ReadLine());



