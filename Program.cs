using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "5511952786714", modelo: "UNBKBLE2022", iMEI: "000000000000000001", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Telegram");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone");

Smartphone iphone = new Iphone(numero: "5511952786714", modelo: "IOSX2022", iMEI: "000000000000000001", memoria: 8);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("IOSWhatsapp");
iphone.InstalarAplicativo("Whatsapp");
