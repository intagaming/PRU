using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Concrete Component*/
public class DarkRoast : Beverage
{
  public override float Cost()
  {
    return 2.49f;
  }

  public override string GetDescription()
  {
    return "Dark Roast";
  }
}
