using System;
using System.Collections.Generic;

namespace ricksGuitars_start;

public class Guitar
{
	private string _serialNumber, _builder, _model, _type, _backWood, _topWood;
	private decimal _price;

	public Guitar(string serialNumber, decimal price,
				  string builder, string model, string type,
				  string backWood, string topWood)
	{
		_serialNumber = serialNumber;
		_price = price;
		_builder = builder;
		_model = model;
		_type = type;
		_backWood = backWood;
		_topWood = topWood;
	}

	public string GetSerialNumber() => _serialNumber;
	public decimal GetPrice() => _price;
	public decimal SetPrice(float price) => _price = (decimal)price;

	public string GetBuilder() => _builder;

	public string GetModel() => _model;

	public string GetTypee() => _type;

	public string GetBackWood() => _backWood;

	public string GetTopWood() => _topWood;
}



