﻿using System;
using System.Text;

public abstract class Car
{
    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension,int durability)
    {
        Brand = brand;

        Model = model;

        YearOfProduction = yearOfProduction;

        Horsepower = horsepower;

        Acceleration = acceleration;

        Suspension = suspension;

        Durability = durability;
    }

    internal void DecreaseDurability(int v)
    {
        Durability -= v;
    }

    public string Brand { get; protected set; }

    public string Model { get; protected set; }

    public int YearOfProduction { get; protected set; }

    public int Horsepower { get; protected set; }

    public int Acceleration { get; protected set; }

    public int Suspension { get; protected set; }

    public int Durability { get; protected set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{Brand} {Model} {YearOfProduction}");
        builder.AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s");
        builder.AppendLine($"{Suspension} Suspension force, {Durability} Durability");

        return builder.ToString().Trim();

    }

    internal virtual void Tune(int tuneIndex, string addOn)
    {
        Horsepower += tuneIndex;
        Suspension += tuneIndex / 2;
    }
}
