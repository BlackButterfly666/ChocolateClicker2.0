using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Texts.Names;

public class IngredientManager : MonoBehaviour
{
	public IngredientEvent IngredientMessage = new IngredientEvent();

	//Stage I - Küche
	[SerializeField] Button cacaoButton;
	[SerializeField] Ingredient cacao;
	int cacaoTotal;
	[SerializeField] Button sugarButton;
	[SerializeField] Ingredient sugar;
	int sugarTotal;
	[SerializeField] Button milkButton;
	[SerializeField] Ingredient milk;
	int milkTotal;
	[SerializeField] Button butterButton;
	[SerializeField] Ingredient butter;
	int butterTotal;
	[SerializeField] Button creamButton;
	[SerializeField] Ingredient cream;
	int creamTotal;
	Product darkChocolate;

	void Start()
	{
		NewIngredient();
		ClickListenerAdd();
	}

	void Update()
	{
		Debug.Log("Name: " + cacao.Name + "Amount per Click: " + cacao.AmountPerClick + "Total: " + cacao.Total);
	}

	/*public void OnClick()
	{
		cacaoTotal += cacao.AmountPerClick;
	}*/

	public void NewIngredient()
	{
		//Stage I - Küche
		//new Ingredient (string name, int amountPerClick, int amountPerSecond
		cacao = new Ingredient(tCacao, 1, 0,ref cacaoTotal);
		sugar = new Ingredient(tSugar, 1, 0, ref sugarTotal);
		milk = new Ingredient(tMilk, 1, 0, ref milkTotal);
		butter = new Ingredient(tButter, 1, 0, ref butterTotal);
		cream = new Ingredient(tCream, 1, 0, ref creamTotal);
	}

	public void NewProduct()
	{
		darkChocolate = new Product("Dark Chocolate", 1, 0, new Ingredient[] { cacao, sugar  });
	}

	public void ClickListenerAdd()
	{
		//Stage I - Küche
		cacaoButton.onClick.AddListener(SetCacao);
		//sugarButton.onClick.AddListener(SetSugar);
		//milkButton.onClick.AddListener(SetMilk);
		//butterButton.onClick.AddListener(SetButter);
		//creamButton.onClick.AddListener(SetCream);
	}

	//Stage I - Küche
	public void SetCacao() { IngredientMessage.Invoke(cacao); }
	public void SetSugar() { IngredientMessage.Invoke(sugar); }
	public void SetMilk() { IngredientMessage.Invoke(milk); }
	public void SetButter() { IngredientMessage.Invoke(butter); }
	public void SetCream() { IngredientMessage.Invoke(cream); }
}
