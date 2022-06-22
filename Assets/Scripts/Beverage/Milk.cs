using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Concretete Decorator*/
public class Milk : CondimentDecorator
{
  public Milk()
  {
  }

  public Milk(Beverage beverage) : base(beverage)
  {
  }

  public override float CondimentCost()
  {
    return .49f;
  }

  public override string GetCondimentDescription()
  {
    return "Milk";
  }
}
