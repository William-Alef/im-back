using MontagemDeMicros.Models;

namespace MontagemDeMicros;
public class Program
{
    static void Main(string[] args)
    {
        var placaMae1 = new PlacaMae("ASUS", "PRIME A520M-E", "Micro ATX, DDR4, AM4", "AM4");
        var processador1 = new Processador("AMD", "Ryzen 5 5600G", "6 núcleos, 12 threads, 4.4GHz Boost", "AM4");
        var placaDeVideo1 = new PlacaDeVideo("Integrada", "Radeon Vega 7", "Gráficos integrados de 7 núcleos");
        var fonte1 = new Fonte("Corsair", "CV550", "550W, PFC ativo", "80 Plus Bronze");
        var ssd1 = new SolidStateDrive("Kingston", "A400", "2.5” SATA", "SATA III", "480GB");
        var hd1 = new HardDisck("Seagate", "Barracuda", "7200RPM, 3.5”", "1TB");
        var airCooler1 = new AirCooler("DeepCool", "GAMMAXX 400 V2", "TDP 180W", "AM4/LGA1200", "120mm, Intel-AMD, DP-MCH4-GMX400V2-RD");

        var pcBasico = new ComputadorPessoal(placaMae1, processador1, placaDeVideo1, fonte1, ssd1, hd1, waterCooler: null, airCooler1);
        pcBasico.ExibirDetalhes();

        var placaMae2 = new PlacaMae("Gigabyte", "B550 AORUS Elite V2", "ATX, DDR4, PCIe 4.0", "AM4");
        var processador2 = new Processador("AMD", "Ryzen 7 5800X", "8 núcleos, 16 threads, 4.7GHz Boost", "AM4");
        var placaDeVideo2 = new PlacaDeVideo("NVIDIA", "GeForce RTX 3060 Ti", "8GB GDDR6, Ray Tracing, DLSS");
        var fonte2 = new Fonte("EVGA", "600 BR", "600W, PFC ativo", "80 Plus Bronze");
        var ssd2 = new SolidStateDrive("Crucial", "P3 Plus", "NVMe PCIe 4.0", "M.2 NVMe", "1TB");
        var hd2 = new HardDisck("Western Digital", "Blue", "5400RPM, 3.5”", "2TB");
        var airCooler2 = new AirCooler("Cooler Master", "Hyper 212 Black Edition", "TDP 200W", "AM4/LGA1700", "Suporta processadores de desktop AMD Ryzen 5000 e 3000 Series (não compatível com AMD Ryzen 5 3400G e Ryzen 3 3200G) e processadores de desktop AMD Ryzen 4000 G-Series");

        var pcIntermediario = new ComputadorPessoal(placaMae2, processador2, placaDeVideo2, fonte2, ssd2, hd: null, waterCooler: null, airCooler2);
        pcIntermediario.ExibirDetalhes();

        var placaMae3 = new PlacaMae("ASUS", "ROG STRIX Z790-E GAMING WIFI", "ATX, DDR5, PCIe 5.0, Wi-Fi 6E", "LGA1700");
        var processador3 = new Processador("Intel", "Core i9-14900K", "24 núcleos, 32 threads, até 6.0GHz", "LGA1700");
        var placaDeVideo3 = new PlacaDeVideo("NVIDIA", "GeForce RTX 4090", "24GB GDDR6X, Ray Tracing, DLSS 3");
        var fonte3 = new Fonte("Corsair", "RM1000e", "1000W modular", "80 Plus Gold");
        var ssd3 = new SolidStateDrive("Samsung", "990 PRO", "PCIe 4.0 NVMe", "M.2 NVMe", "2TB");
        var hd3 = new HardDisck("Seagate", "IronWolf", "7200RPM, NAS Ready", "4TB");
        var waterCooler3 = new WaterCooler("NZXT", "Kraken Elite 360 RGB", "Radiador triplo, bomba silenciosa", "LGA1700/AM5", "");

        var pcHighEnd = new ComputadorPessoal(placaMae3, processador3, placaDeVideo3, fonte3, ssd3, hd3, waterCooler3, airCooler: null);
        pcHighEnd.ExibirDetalhes();
        /*
        Você está desenvolvendo um sistema para um centro técnico especializado na montagem de computadores personalizados. Cada computador é composto por diferentes peças, e cada peça possui características próprias. Ao invés de herdar, faz mais sentido compor um computador com essas peças, já que um computador tem uma placa-mãe, tem um processador, e assim por diante.
        Seu desafio é criar uma estrutura que represente essa montagem usando composição.
        Crie um programa que:

        Defina a classe Processador, com os atributos Marca e Modelo.
        Defina a classe PlacaMae, com os atributos Fabricante e Socket.
        Crie a classe Computador, que possua como atributos um Processador e uma PlacaMae.
        Instancie objetos das peças com dados fictícios e associe a um objeto da classe Computador.
        Crie um método ExibirConfiguracao() na classe Computador que exiba no console os dados completos do computador.
         */
    }
}