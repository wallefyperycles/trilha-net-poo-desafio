using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();

System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
//====================================================
//Delay simulando uma ligação
//====================================================
await Task.Delay(2000);
System.Console.WriteLine(".");
await Task.Delay(2000);
Console.Clear();
System.Console.WriteLine("..");
await Task.Delay(2000);
Console.Clear();
System.Console.WriteLine("...");
await Task.Delay(2000);
Console.Clear();
//===================================================
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n"); // pular linha

System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo 2", imei: "222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");