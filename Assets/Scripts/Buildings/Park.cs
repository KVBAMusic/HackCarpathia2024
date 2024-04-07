using UnityEngine;

public class Park : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};

    public int EnergyGeneration => -5;

    public void Advance() {
        GameState.State.AirPollution -= 5;
        GameState.State.WaterPollution -= 10;
        GameState.State.GroundPollution -= 1;
    }
    public void OnBuild() {}
}