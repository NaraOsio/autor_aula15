public class Autor //class
{
    public string  Nome;
    public string  Nacionalidade;
   
    public Autor(string Nome, string Nacionalidade) //construtor
    {
        this.Nome = Nome;
        this.Nacionalidade = Nacionalidade;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nome do autor: {Nome}, nacionalidade: {Nacionalidade}");
    }
    

}
