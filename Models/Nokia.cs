namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero,string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"{nomeApp} instalado com sucesso no seu Nokia!");
        }
    }
}