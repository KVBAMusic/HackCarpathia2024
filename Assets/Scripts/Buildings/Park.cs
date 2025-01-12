using UnityEngine;

public class Park : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};

    public int EnergyGeneration => -50;
    public int Cost => 500;

    public void Advance() {
        GameState.State.AirPollution -= 5;
        GameState.State.WaterPollution -= 5;
    }
    public void OnBuild() {}
}