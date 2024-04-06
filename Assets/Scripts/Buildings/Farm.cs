using UnityEngine;
using System.Collections.Specialized;

public class Farm : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};
    public void Advance() {
        GameState.state.Money += 20;
    }
}