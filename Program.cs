Autor Autor1 = new Autor ("Mauricio de Souza", "Brazuca");
Autor1.MostrarInfo();

Livro Livro1 = new Livro ("Turma da Monica", Autor1, 100.00);

Livro1.MostrarInfo();

Livro1.AplicarDesconto(10.0);
Livro1.MostrarInfo();

Livro1.AplicarDesconto(5);
Livro1.MostrarInfo();


Biblioteca biblioteca = new Biblioteca();
biblioteca.nome = "Lutero";
biblioteca.endereco = "Rua universitaria";
biblioteca.Livro = livro1; 

