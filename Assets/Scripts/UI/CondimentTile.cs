using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CondimentTile : MonoBehaviour
{
  const string NOT_CHOSEN_TEXT = "Choose";
  const string CHOSEN_TEXT = "Selected";

  [SerializeField]
  private TMP_Text _condimentName;
  [SerializeField]
  private TMP_Text _condimentPrice;
  [SerializeField]
  private Button _chooseButton;

  private CondimentDecorator _condiment;
  public CondimentDecorator CondimentDecorator => _condiment;

  private CondimentContainer _container;

  public bool Chosen { get; set; }

  public void Init(CondimentDecorator c, CondimentContainer container)
  {
    _condiment = c;
    _condimentName.text = c.GetCondimentDescription();
    _condimentPrice.text = "$" + c.CondimentCost().ToString();
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
    Chosen = !Chosen;
    if (Chosen)
    {
      Select();
    }
    else
    {
      Deselect();
    }
  }
}
