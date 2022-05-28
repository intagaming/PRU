using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decaf : Beverage
{
  public override float Cost()
  {
    return 2.99f;
  }

  public override string GetDescription()
  {
    return "Decaf";
  }
}
