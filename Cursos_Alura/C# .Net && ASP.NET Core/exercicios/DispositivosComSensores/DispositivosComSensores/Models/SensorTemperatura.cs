﻿using DispositivosComSensores.Interfaces;
namespace DispositivosComSensores.Models;
public class SensorTemperatura : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de temperatura ativado.");
    }

    public void Desativar()
    {
        Console.WriteLine("Sensor de temperatura desativado.");
    }
}
