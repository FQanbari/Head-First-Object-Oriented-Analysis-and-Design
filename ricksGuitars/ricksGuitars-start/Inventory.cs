using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ricksGuitars_start;

internal class Inventory
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
            if (guitar.GetSerialNumber().Equals(serialNumber))
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
            if (!string.IsNullOrEmpty(searchGuitar.GetBuilder()) && !guitar.GetBuilder().Equals(searchGuitar.GetBuilder()))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.GetModel()) && !guitar.GetModel().Equals(searchGuitar.GetModel()))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.GetTypee()) && !guitar.GetTypee().Equals(searchGuitar.GetTypee()))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.GetBackWood()) && !guitar.GetBackWood().Equals(searchGuitar.GetBackWood()))
                continue;

            if (!string.IsNullOrEmpty(searchGuitar.GetTopWood()) && !guitar.GetTopWood().Equals(searchGuitar.GetTopWood()))
                continue;

            return guitar;
        }
        return null;
    }
}
