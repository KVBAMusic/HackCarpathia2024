using UnityEngine;

public class WindTurbine : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground, TileType.Water};

    public int EnergyGeneration => 200;

    public void Advance() {
    }
}