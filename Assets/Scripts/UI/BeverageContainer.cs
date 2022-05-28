using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeverageContainer : MonoBehaviour
{
  [SerializeField]
  private BeverageTile _beverageTile;

  private List<BeverageTile> _tiles = new List<BeverageTile>();
  private BeverageTile _chosen = null;
  public BeverageTile Chosen => _chosen;

  public void AddBeverage(Beverage b)
  {
    var tile = Instantiate(_beverageTile, Vector3.zero, Quaternion.identity, transform);
    tile.Init(b, this);
    _tiles.Add(tile);
  }

  public void ChooseBeverage(BeverageTile tile)
  {
    _tiles.ForEach(t => t.Deselect());
    tile.Select();
    _chosen = tile;
  }
}
