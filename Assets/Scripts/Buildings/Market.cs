using UnityEngine;

public class Market : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => -5;

    public void Advance() {
        GameState.State.AirPollution += 1;
        GameState.State.Money += 250;
    }
    public void OnBuild() {}
}