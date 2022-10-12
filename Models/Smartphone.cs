namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Passar os parâmetros do construtor para as propriedades
        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public string ObterModelo()
        {
            return Modelo;
        }
        public string ObterIMEI()
        {
            return IMEI;
        }
        public int ObterMemoria()
        {
            return Memoria;
        }


        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}