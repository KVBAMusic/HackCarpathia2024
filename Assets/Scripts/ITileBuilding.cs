
public interface ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn { get; }
    public int EnergyGeneration { get; }
    public int Cost { get; }
    public void Advance();
    public void OnBuild();
}