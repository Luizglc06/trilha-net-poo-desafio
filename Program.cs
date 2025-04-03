using DesafioPOO.Models;

Console.WriteLine("NOKIA :\n");
Nokia nokia = new Nokia("00000000001", "Nokia 2025", "00000-01-010000-1", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("IPHONE :\n");
Iphone iphone = new Iphone("00000000001","Iphone 15", "7584930584639560", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");