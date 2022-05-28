using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espresso : Beverage
{
  public override float Cost()
  {
    return 1.99f;
  }

  public override string GetDescription()
  {
    return "Espresso";
  }
}
