using DesafioPOO.Models;


Console.WriteLine("SmartFone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111-11", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SmartFone iPhone:");
Smartphone iphone = new Iphone(numero: "498799", modelo: "Modelo 2", imei: "222222222-22", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
