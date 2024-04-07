using UnityEngine;

public class Supermarket : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => -300;
    public int Cost => 500;

    public void Advance() {
        GameState.State.Money += 500;
        GameState.State.AirPollution += 10;
        GameState.State.GroundPollution += 5;
    }
    public void OnBuild() {}
}