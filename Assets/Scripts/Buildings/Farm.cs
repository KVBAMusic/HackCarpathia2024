using UnityEngine;

public class Farm : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};

    public int EnergyGeneration => 0;
    public int EnergyUsage => 5;
    public int Cost => 5;

    public void Advance() {
        GameState.State.AirPollution += 2;
        GameState.State.Money += 5 * GameState.State.FarmMultiplier;
    }
    public void OnBuild() {}
}