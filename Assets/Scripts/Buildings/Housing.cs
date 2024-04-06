using UnityEngine;

public class Housing : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => -250;

    public void Advance() {
        GameState.State.Money += 500;
        GameState.State.AirPollution += 5;
        GameState.State.WaterPollution += 10;
        GameState.State.GroundPollution += 1;
    }
}