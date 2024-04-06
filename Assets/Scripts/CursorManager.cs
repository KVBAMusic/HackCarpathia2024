using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public new Camera camera;
    public Tile targetTile;
    private ITileBuilding targetBuilding;
    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonUp(0)) {
            Ray mouseRay = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out var hitInfo)) {
                if (hitInfo.collider.gameObject.TryGetComponent<Tile>(out var tile)) {
                    if (targetTile is not null) {
                        targetTile.selected = false;
                    }
                    targetTile = tile;
                    targetBuilding = tile.building;
                    targetTile.selected = true;
                    Debug.Log(tile.Pos);
                    return;
                }
                if (hitInfo.collider.gameObject.TryGetComponent<ITileBuilding>(out var building)) {
                    if (targetTile is not null) {
                        targetTile.selected = false;
                    }
                    targetTile = building.Parent;
                    targetBuilding = building;
                    targetTile.selected = true;
                    Debug.Log(targetTile.Pos);
                    return;
                }
                return;
            }
            Debug.Log("Not hit");
            if (targetTile is not null) {
                targetTile.selected = false;
            }
            targetTile = null;
        }
    }
}
