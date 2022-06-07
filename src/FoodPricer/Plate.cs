using FoodPricer;
using System;

public class Plate : Meal {

  private string name;
  private string beverage;
  private string size;
  private string dessert;
  private string dsize;
  private string coffee;

  public Plate(string name, string beverage, string size, string dessert, string dsize, string coffee){
    this.name = name;
    this.beverage = beverage;
    this.size = size;
    this.dessert = dessert;
    this.dsize = dsize;
    this.coffee = coffee;
  }

  public decimal GetPrice() {
    var total = 15;
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
                    total=18;
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
                    total=21;
                }
                break;
        }

    if( size=="moyen" && dsize=="normal" && coffee=="yes")
    {
        Console.Write(" avec café offert!");
    } else {
        total+=1;
    }
    return total;
  }
}