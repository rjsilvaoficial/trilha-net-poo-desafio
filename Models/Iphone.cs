namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp.StartsWith("IOS") ? $"Instalando o aplicativo {nomeApp} no Iphone!" : $"{nomeApp} não instalado! Aplicativo não oficial!");
        }
    }
}