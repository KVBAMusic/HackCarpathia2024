using UnityEngine;

public class WaterPurifier : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Water};

    public int EnergyGeneration => -500;

    public void Advance() {
    }
}