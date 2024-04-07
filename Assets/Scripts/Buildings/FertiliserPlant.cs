using UnityEngine;

public class FertiliserPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground, TileType.Barren};

    public int EnergyGeneration => -50;
    public int Cost => 50;

    public void Advance() {
        GameState.State.AirPollution += 5;
        GameState.State.WaterPollution += 5;
        GameState.State.GroundPollution += 5;
    }

    void OnDestroy() {
        GameState.State.FarmMultiplier -= 1;
    }
    public void OnBuild() {
        GameState.State.FarmMultiplier += 1;
        Parent.tileType = TileType.Barren;
    }
}