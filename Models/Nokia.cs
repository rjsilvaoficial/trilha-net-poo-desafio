namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria) { }



        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            int tamanhoApp = nomeApp.Length;

            Console.WriteLine(tamanhoApp <= ObterMemoria() ? $"{nomeApp} instalado com sucesso!" 
                                                          : $"{nomeApp} não instalado! Memória insuficiente!");

        }
    }
}