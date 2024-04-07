using UnityEngine;

public class Meadow : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Ground};

    public int EnergyGeneration => 0;
    public int Cost => 20;

    private int life = 2;
    public void Advance() {
        GameState.State.GroundPollution -= 10;
        if (--life <= 0) {
            Parent.building = null;
            Destroy(gameObject);
        }
    }
    public void OnBuild() {}
}