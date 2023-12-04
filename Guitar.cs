using System;
using System.Collections.Generic;

namespace Head-First-Object-Oriented-Analysis-and-Design.chapter01.ricksGuitars-start

public class Guitar
{
	private string serialNumber, builder, model, type, backWood, topWood;
	private decimal price;

	public Guitar(string serialNumber, decimal price,
				  string builder, string model, string type,
				  string backWood, string topWood)
	{
		this.serialNumber = serialNumber;
		this.price = price;
		this.builder = builder;
		this.model = model;
		this.type = type;
		this.backWood = backWood;
		this.topWood = topWood;
	}

	public string SerialNumber => serialNumber;

	public decimal Price
	{
		get => price;
		set => price = value;
	}

	public string Builder => builder;

	public string Model => model;

	public string Type => type;

	public string BackWood => backWood;

	public string TopWood => topWood;
}



