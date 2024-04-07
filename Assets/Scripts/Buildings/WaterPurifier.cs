using UnityEngine;

public class WaterPurifier : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Water};

    public int EnergyGeneration => -50;
    public int Cost => 100;

    public void Advance() {
        GameState.State.WaterPollution -= 5;
    }
    public void OnBuild() {}
}