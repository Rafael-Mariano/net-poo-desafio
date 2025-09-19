using DesafioPOO.Models;

Console.WriteLine("Celular Nokia:");
Nokia n = new Nokia(numero: "1234", modelo: "g13", imei: "142536", memoria: 256);
n.ReceberLigacao();
n.Ligar();
n.InstalarAplicativo(nomeApp: "whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone:");
Iphone i = new Iphone(numero: "4321", modelo: "SE", imei: "142356", memoria: 128);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo(nomeApp: "calculadora");