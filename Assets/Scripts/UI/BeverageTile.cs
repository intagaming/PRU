using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BeverageTile : MonoBehaviour
{
  const string NOT_CHOSEN_TEXT = "Choose";
  const string CHOSEN_TEXT = "Selected";

  [SerializeField]
  private TMP_Text _beverageName;
  [SerializeField]
  private TMP_Text _beveragePrice;
  [SerializeField]
  private Button _chooseButton;

  private Beverage _beverage;
  public Beverage Beverage => _beverage;

  private BeverageContainer _container;

  public void Init(Beverage b, BeverageContainer container)
  {
    _beverage = b;
    _beverageName.text = b.GetDescription();
    _beveragePrice.text = "$" + b.Cost().ToString();
    _container = container;
  }

  public void Deselect()
  {
    _chooseButton.GetComponentInChildren<TMP_Text>().text = NOT_CHOSEN_TEXT;
  }

  public void Select()
  {
    _chooseButton.GetComponentInChildren<TMP_Text>().text = CHOSEN_TEXT;
  }

  public void OnChooseButtonPress()
  {
    _container.ChooseBeverage(this);
  }
}
