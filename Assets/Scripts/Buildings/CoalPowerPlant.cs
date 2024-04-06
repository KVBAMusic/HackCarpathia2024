using UnityEngine;

public class CoalPowerPlant : MonoBehaviour, ITileBuilding {
    public Tile Parent { get; set; }
    public void Advance() {
        GameState.state.Money -= 50;
    }
}