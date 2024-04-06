using UnityEngine;

public class Farm : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};
    public void Advance() {
        GameState.State.Energy -= 5;
        GameState.State.AirPollution += 5;
    }
}