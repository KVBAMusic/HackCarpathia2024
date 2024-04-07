using UnityEngine;

public class WindTurbine : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground, TileType.Water};

    public int EnergyGeneration => 250;
    public int Cost => 250;

    public void Advance() {
    }
    public void OnBuild() {}
}