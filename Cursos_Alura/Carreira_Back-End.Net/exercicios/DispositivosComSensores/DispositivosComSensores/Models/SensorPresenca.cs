﻿using DispositivosComSensores.Interfaces;

namespace DispositivosComSensores.Models;
public class SensorPresenca : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de presença ativado.");
    }

    public void Desativar()
    {
        Console.WriteLine("Sensor de presença desativado.");
    }
}
