using DesafioPOO.Models;

void TestarSmartphone(Smartphone smartphone, string nomeApp)
{
    Console.WriteLine($"Smartphone {smartphone.Modelo}");
    smartphone.Ligar();
    smartphone.InstalarAplicativo(nomeApp);
    Console.WriteLine();
}


Smartphone nokia = new Nokia(numero: "40028922", modelo: "Modelo 1", imei: "0101010101", memoria: 256);
TestarSmartphone(nokia, "Zapzap");


Smartphone iphone = new Iphone(numero: "08009090", modelo: "Modelo 2", imei: "0202020202", memoria: 500);
TestarSmartphone(iphone, "Tigrinho");
