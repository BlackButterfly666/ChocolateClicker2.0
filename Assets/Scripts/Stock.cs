using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Stock : MonoBehaviour
{
	Ingredient secretIngredient;

	public void SetIngredient(Ingredient ingredient)
	{
		secretIngredient = ingredient;
		secretIngredient.Total += secretIngredient.AmountPerClick + secretIngredient.AmountPerSecond;
	}
}

//Boilerplate Code für Unity um ein ein Event mit Custom Data zu bekommen
[System.Serializable]
public class IngredientEvent : UnityEvent<Ingredient> { }

//Serializable und SerializeField, um die Zutaten im Editor sichtbar zu machen
[System.Serializable]
public struct Ingredient
{
	//private Backing-Varable und public Property
	[SerializeField] string name;
	public string Name { get { return name; } }

	[SerializeField] int amountPerClick;
	public int AmountPerClick { get { return amountPerClick; } set { amountPerClick = value; } }

	int total;
	public int Total { get { return total; } set { total = value; } }

	[SerializeField] int amountPerSecond;
	public int AmountPerSecond { get { return amountPerSecond; } set { amountPerSecond = value; } }

	//Constructor
	public Ingredient(string name, int amountPerClick, int amountPerSecond, ref int total)
	{
		this.name = name;
		this.amountPerClick = amountPerClick;
		this.amountPerSecond = amountPerSecond;
		this.total = total;
	}
}

public class Product
{
	//private Backing-Varable und public Property
	[SerializeField] string name;
	public string Name { get { return name; } }

	[SerializeField] int amountPerClick;
	public int AmountPerClick { get { return amountPerClick; } set { amountPerClick = value; } }

	[SerializeField] int total = 0;
	public int Total { get { return total; } set { total = value; } }

	[SerializeField] int amountPerSecond;
	public int AmountPerSecond { get { return amountPerSecond; } set { amountPerSecond = value; } }

	Ingredient[] ingredients;

	//Constructor
	public Product(string name, int amountPerClick, int amountPerSecond, Ingredient[] ingredients)
	{
		this.name = name;
		this.amountPerClick = amountPerClick;
		this.amountPerSecond = amountPerSecond;
		this.ingredients = ingredients;

		//ToDo => recipe ingredients
	}
}
