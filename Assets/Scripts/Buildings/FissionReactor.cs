using UnityEngine;

public class FissionReactor : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => 25000;

    void OnEnable() {
        Parent.tileType = TileType.Barren;
    }

    public void Advance() {
        GameState.State.WaterPollution += 5;
        GameState.State.GroundPollution += 25;
    }
}