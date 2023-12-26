using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone n = new Nokia(numero: "87981798837", modelo: "A3256", imei: "2222222222222222", memoria: 128);
Smartphone i = new Iphone(numero: "87981268666", modelo: "8 plus", imei: "333333333333333333", memoria: 256);
Console.WriteLine("Smartphone Nokia: ");
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Whatsapp");
n.MostrarCelular();

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone: ");
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Telegram");
i.MostrarCelular();