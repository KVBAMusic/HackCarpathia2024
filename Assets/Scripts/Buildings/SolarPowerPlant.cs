using UnityEngine;

public class SolarPowerPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};
    public void Advance() {
        GameState.State.Energy += 20;
    }
}