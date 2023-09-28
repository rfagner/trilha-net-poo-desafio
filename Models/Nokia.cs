namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
         // Construtor da classe Nokia que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Substitui o método InstalarAplicativo da classe base (Smartphone)
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia");
        }
    }
}