using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CondimentContainer : MonoBehaviour
{
  [SerializeField]
  private CondimentTile _condimentTile;

  private List<CondimentTile> _tiles = new List<CondimentTile>();

  public void AddCondiment(CondimentDecorator c)
  {
    var tile = Instantiate(_condimentTile, Vector3.zero, Quaternion.identity, transform);
    tile.Init(c, this);
    _tiles.Add(tile);
  }

  public List<CondimentTile> Chosens => _tiles.Where(t => t.Chosen).ToList();
}
