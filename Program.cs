using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("121314", "modelo 1", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("111222", "Iphone 12", "2222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");