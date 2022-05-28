using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
Due to Unity shortcuts, we would need the condiment's individual description
and cost.
*/
public abstract class CondimentDecorator : Beverage
{
  public Beverage Beverage { get; set; }

  public CondimentDecorator(Beverage beverage)
  {
    Beverage = beverage;
  }


  // Additional methods to use in Unity

  protected CondimentDecorator()
  {
  }
  public abstract string GetCondimentDescription();
  public abstract float CondimentCost();


  // Decorator's methods below

  public override string GetDescription()
  {
    return Beverage.GetDescription() + ", " + GetCondimentDescription();
  }

  public override float Cost()
  {
    return CondimentCost() + Beverage.Cost();
  }
}
