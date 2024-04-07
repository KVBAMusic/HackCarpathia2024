using UnityEngine;

public class WaterTurbine : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Water};

    public int EnergyGeneration => 300;

    public void Advance() {
    }
    public void OnBuild() {}
}