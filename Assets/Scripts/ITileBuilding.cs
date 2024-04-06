
public interface ITileBuilding {
    public Tile Parent { get; set; }
    public TileType[] PlacedOn { get; }
    public void Advance();
}