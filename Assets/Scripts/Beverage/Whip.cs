using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whip : CondimentDecorator
{
  public Whip()
  {
  }

  public Whip(Beverage beverage) : base(beverage)
  {
  }

  public override float CondimentCost()
  {
    return .49f;
  }

  public override string GetCondimentDescription()
  {
    return "Whip";
  }
}
