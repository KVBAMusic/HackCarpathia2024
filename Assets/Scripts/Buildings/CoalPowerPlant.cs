using UnityEngine;

public class CoalPowerPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => 40;
    public void Advance() {
        GameState.State.AirPollution += 40;
    }
}