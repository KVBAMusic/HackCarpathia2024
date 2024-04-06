using UnityEngine;

public class Farm : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public void Advance() {
        GameState.state.Money += 20;
    }
}