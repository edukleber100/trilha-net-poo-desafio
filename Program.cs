using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone celular1 = new Iphone("81981037321","Iphone", "1283102hkjk", 128);
Smartphone celular2 = new Nokia("81988227027","Nokia", "8310293hdsa", 60);

celular1.Ligar();
celular1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

celular2.ReceberLigacao();
celular2.InstalarAplicativo("Discord");