using UnityEngine;

public class CoalPowerPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};
    public void Advance() {
        GameState.State.Energy += 40;
        GameState.State.AirPollution += 40;
    }
}