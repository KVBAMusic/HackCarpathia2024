using UnityEngine;

public class FusionReactor : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn => new TileType[] {TileType.Barren, TileType.Ground};

    public int EnergyGeneration => 1000000;

    public void OnBuild() { Parent.tileType = TileType.Barren; }

    public void Advance() {
    }
}