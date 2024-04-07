using UnityEngine;

public class WaterTurbine : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Water};

    public int EnergyGeneration => 150;
    public int Cost => 150;

    public void Advance() {
    }
    public void OnBuild() {}
}