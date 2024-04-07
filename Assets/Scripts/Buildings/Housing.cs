using UnityEngine;

public class Housing : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => -500;
    public int Cost => 750;

    public void Advance() {
        GameState.State.Money += 1000;
        GameState.State.AirPollution += 5;
        GameState.State.WaterPollution += 5;
    }
    public void OnBuild() {}
}