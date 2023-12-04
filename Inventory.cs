using System.Collections.Generic;
using System;

namespace Head-First-Object-Oriented-Analysis-and-Design.chapter01.ricksGuitars-start

public class Inventory
{
    private List<Guitar> guitars;

    public Inventory()
    {
        guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, decimal price,
                          string builder, string model,
                          string type, string backWood, string topWood)
    {
        Guitar guitar = new Guitar(serialNumber, price, builder,
                                   model, type, backWood, topWood);
        guitars.Add(guitar);
    }

    public Guitar GetGuitar(string serialNumber)
    {
        foreach (var guitar in guitars)
        {
            if (guitar.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase))
            {
                return guitar;
            }
        }
        return null;
    }

    public Guitar Search(Guitar searchGuitar)
    {
        foreach (var guitar in guitars)
        {
            // Ignore serial number since that's unique
            // Ignore price since that's unique
            if (!string.IsNullOrEmpty(searchGuitar.Builder) && !guitar.Builder.Equals(searchGuitar.Builder, StringComparison.OrdinalIgnoreCase))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.Model) && !guitar.Model.Equals(searchGuitar.Model, StringComparison.OrdinalIgnoreCase))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.Type) && !guitar.Type.Equals(searchGuitar.Type, StringComparison.OrdinalIgnoreCase))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.BackWood) && !guitar.BackWood.Equals(searchGuitar.BackWood, StringComparison.OrdinalIgnoreCase))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.TopWood) && !guitar.TopWood.Equals(searchGuitar.TopWood, StringComparison.OrdinalIgnoreCase))
                continue;

            return guitar;
        }
        return null;
    }
}