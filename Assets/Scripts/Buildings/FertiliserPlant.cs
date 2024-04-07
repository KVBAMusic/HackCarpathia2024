using UnityEngine;

public class FertiliserPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground, TileType.Barren};

    public int EnergyGeneration => -150;

    public void Advance() {
        GameState.State.AirPollution += 10;
        GameState.State.WaterPollution += 25;
        GameState.State.GroundPollution += 10;
        GameState.State.Money += 100;
    }

    void OnDestroy() {
        GameState.State.FarmMultiplier -= 1;
    }
    public void OnBuild() {
        GameState.State.FarmMultiplier += 1;
    }
}