using UnityEngine;

public class Supermarket : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => -200;

    public void Advance() {
        GameState.State.Money += 1000;
        GameState.State.AirPollution += 10;
        GameState.State.GroundPollution += 15;
    }
}