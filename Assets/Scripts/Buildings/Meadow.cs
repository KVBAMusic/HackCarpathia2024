using UnityEngine;

public class Meadow : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};

    public int EnergyGeneration => 0;

    private int life = 2;
    public void Advance() {
        GameState.State.GroundPollution -= 15;
        if (--life <= 0) {
            Parent.building = null;
            Destroy(gameObject);
        }
    }
    public void OnBuild() {}
}