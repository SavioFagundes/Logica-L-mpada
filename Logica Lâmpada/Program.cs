namespace Logica_Lâmpada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?  
            Console.WriteLine("Iria para outra sala, deixaria a luz ligada por algum tempo, desligaria, iria para uma segunda sala, ligaria por um tempo menor que a primeira ligada, e testaria o tato em cada uma das lampadas\n" +
                "ficando assim: lampada com a temperatura mais elevada, a primeira ligada" +
                "lampada com temperatura abaixo da primeira, sendo a segunda ligada" +
                "lampada completamente morna/fria, seria a última, ou seja, a que eu não teria ligado nesse teste.");
        }
    }
}