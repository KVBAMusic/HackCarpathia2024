using UnityEngine;

public class Market : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => -15;
    public int Cost => 50;

    public void Advance() {
        GameState.State.AirPollution += 5;
        GameState.State.Money += 100;
    }
    public void OnBuild() {}
}