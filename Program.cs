using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace trilha-net-poo-desafio
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia("123456789", "Modelo Nokia", "123456789012345", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone("987654321", "Modelo Iphone", "987654321098765", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}