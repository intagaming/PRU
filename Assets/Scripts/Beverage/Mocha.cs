using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mocha : CondimentDecorator
{
  public Mocha()
  {
  }

  public Mocha(Beverage beverage) : base(beverage)
  {
  }

  public override float CondimentCost()
  {
    return .99f;
  }

  public override string GetCondimentDescription()
  {
    return "Mocha";
  }
}
