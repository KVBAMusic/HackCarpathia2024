using UnityEngine;

public class CoalPowerPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => 25;

    public int Cost => 25;

    public void Advance() {
        GameState.State.AirPollution += 15;
    }

    public void OnBuild() {
        Parent.tileType = TileType.Barren;
    }
}