using FoodPricer;
using System;

public class Menu {

  private Meal meal;
  
  private string coffee;


  public Menu(string type, string name, string beverage, string size, string dessert, string dsize, string coffee) {
    switch (type) 
    {
      case "sandwich":
        this.meal = new Sandwich(name, beverage, size, dessert,dsize, coffee);
        break;
      case "assiette":
        this.meal = new Plate(name, beverage, size, dessert, dsize, coffee);
        break;
      default:
        this.meal = new Plate(name, beverage, size, dessert, dsize, coffee);
        break;
    }
    this.coffee = coffee;
  }

  public decimal getPrice() {
    //prix total à payer pour le client

    return this.meal.GetPrice();
    
  }
}