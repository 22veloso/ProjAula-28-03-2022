using ProjAula4;

Carro carro = new Carro();
carro.Id = 1;
carro.Marca = "FIAT";
carro.Modelo = "TORO";
carro.AnoFabricacao = 2022;
carro.AnoModelo = 2022;
carro.Cor = "Preto";
carro.Ligar();
carro.Acelerar(100);
carro.LigarBuzina();

Carro carro2 = new Carro()
{
    Id = 2,
    Marca = "hyundai",
    Modelo = "creta",
    AnoFabricacao = 2020,
    AnoModelo = 2020,
    Cor = "branco",
};

Console.WriteLine(carro);
Console.WriteLine(carro2);