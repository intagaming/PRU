using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Concretete Decorator*/
public class Soy : CondimentDecorator
{
  public Soy()
  {
  }

  public Soy(Beverage beverage) : base(beverage)
  {
  }

  public override float CondimentCost()
  {
    return .49f;
  }

  public override string GetCondimentDescription()
  {
    return "Soy";
  }
}
