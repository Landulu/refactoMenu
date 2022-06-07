using FoodPricer;
using System;

public class Sandwich : Meal {

  private string name;
  private string beverage;
  private string size;
  private string dessert;
  private string dsize;
  private string coffee;

  public Sandwich(string name, string beverage, string size, string dessert, string dsize, string coffee){
    this.name = name;
    this.beverage = beverage;
    this.size = size;
    this.dessert = dessert;
    this.dsize = dsize;
    this.coffee = coffee;
  }

  public decimal GetPrice() {
    var total = 10;
        //ainsi qu'une boisson de taille:
        switch(size)
        {
            case "petit": 
                total+=2;
                //dans ce cas, on applique la formule standard
                if(dsize=="normal")
                {
                    //pas de formule
                    //on ajoute le prix du dessert normal
                    total+=2;
                } else {
                    //sinon on rajoute le prix du dessert special
                    total+=4;
                }
                break;
            //si on prends moyen
            case "moyen": 
                total+=3;
                //dans ce cas, on applique la formule standard
                if(dsize=="normal")
                {
                    //j'affiche la formule appliquée
                    Console.Write("Prix Formule Standard appliquée ");
                    //le prix de la formule est donc 18
                    total=13;
                } else {
                    //sinon on rajoute le prix du dessert special
                    total+=4;
                }
                break;
            case "grand": 
                total+=4;
                //dans ce cas, on applique la formule standard
                if(dsize=="normal")
                {
                    //pas de formule
                    //on ajoute le prix du dessert normal
                    total+=2;
                } else {
                    //dans ce cas on a la fomule max
                    Console.Write("Prix Formule Max appliquée ");
                    total=16;
                }
                break;
        }

    if (coffee == "yes") {
      total += 1;
    }
    
    return total;
  }
}