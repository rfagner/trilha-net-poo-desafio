using DesafioPOO.Models;

// Criação de um objeto Smartphone da classe Nokia
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "N95", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

// Criação de um objeto Smartphone da classe Iphone
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "74108520", modelo: "11", imei: "222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
