using UnityEngine;

public class SolarPowerPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => 70;
    public int Cost => 80;

    public void Advance() {
    }
    public void OnBuild() {}
}