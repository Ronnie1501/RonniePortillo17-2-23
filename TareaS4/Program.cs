using TareaS4.entidades;
using TareaS4.negocio;

internal class Program
{
    private static void Main(string[] args)
    {
        EntidadCont Texto = new EntidadCont();
        ClsNegocioCont clsNegocioContador = new ClsNegocioCont();



        Console.WriteLine("Ingrese un Texto:");
        string? TextoIngr = Console.ReadLine();

        EntidadCont entidad = new EntidadCont();
        entidad.Texto = TextoIngr!;

        ClsNegocioCont negocio = new ClsNegocioCont();
        int NumLetras = negocio.LetrasCont(entidad);

        Console.WriteLine("El número total de letras ingresadas son: " + NumLetras);
    }
}