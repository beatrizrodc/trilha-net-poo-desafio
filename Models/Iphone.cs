namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string imei, string modelo, int memoria) : 
        base (numero, imei, modelo, memoria){

        }
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando o aplicativo {nomeApp} no IPhone.");
        }
    }
}