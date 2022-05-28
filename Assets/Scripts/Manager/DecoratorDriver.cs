using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DecoratorDriver : MonoBehaviour
{
  [SerializeField]
  private BeverageContainer _beverageContainer;
  [SerializeField]
  private CondimentContainer _condimentContainer;
  [SerializeField]
  private TMP_Text _totalText;

  void Start()
  {
    _beverageContainer.AddBeverage(new Espresso());
    _beverageContainer.AddBeverage(new DarkRoast());
    _beverageContainer.AddBeverage(new Decaf());

    _condimentContainer.AddCondiment(new Milk());
    _condimentContainer.AddCondiment(new Mocha());
    _condimentContainer.AddCondiment(new Soy());
    _condimentContainer.AddCondiment(new Whip());
  }

  public void OnBuyButtonPress()
  {
    CalculateTotal();
  }

  public void CalculateTotal()
  {
    // Must choose one beverage first
    if (_beverageContainer.Chosen == null) return;

    // Fetch the chosen beverage and condiments
    var beverage = _beverageContainer.Chosen.Beverage;
    var condiments = _condimentContainer.Chosens.Select(t => t.CondimentDecorator).ToList();

    if (condiments.Count == 0)
    {
      _totalText.text = $"You ordered {beverage.GetDescription()} for ${beverage.Cost()}";
      return;
    }

    // Start wrapping beverage with condiments
    var toBeWrapped = beverage;

    while (condiments.Count != 0)
    {
      // Take the condiment
      var nextWrapper = condiments.First();
      condiments.RemoveAt(0);

      // Wrap
      nextWrapper.Beverage = toBeWrapped;

      // Awaiting the next condiment
      toBeWrapped = nextWrapper;
    }

    _totalText.text = $"You ordered {toBeWrapped.GetDescription()} for ${toBeWrapped.Cost()}";
  }
}
