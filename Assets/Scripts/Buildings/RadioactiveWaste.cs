using UnityEngine;

public class RadioactiveWaste : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => 0;

    public void Advance() {
        GameState.State.GroundPollution -= 25;
    }
    public void OnBuild() {}
}