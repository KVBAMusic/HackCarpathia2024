using UnityEngine;

public class Forest : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};

    public int EnergyGeneration => 0;
    public int Cost => 10;

    public void Advance() {
        GameState.State.AirPollution -= 5;
    }

    public void OnBuild() {}
}