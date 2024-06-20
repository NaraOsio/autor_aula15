public class Livro
{
    public string Titulo;// aqui é atributos
    public Autor autor;// aqui é atributos
    public double preco;// aqui é atributos

    public Livro(string titulo, Autor autor)//metodo construtor
    {
        this.Titulo = titulo;
        this.autor = autor;
    }
    public Livro(string titulo, Autor autor, double preco)//metodo construtor
    {
        this.Titulo = titulo;
        this.autor = autor;
        this.preco = preco; 
    }

    public void mostrarInfo()
    {
       Console.WriteLine($"Titulo: {Titulo}, Autor: {autor.Nome}, preco: {preco}");
    }
    public void AplicarDesconto(double valor)
    {
        preco -= preco * (valor / 100);
    }
    public void aplicarDesconto(int valor)
    {
          preco = - preco - valor;
    }

     







}
    








