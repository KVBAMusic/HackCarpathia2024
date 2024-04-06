using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManager : MonoBehaviour
{
    public new Camera camera;
    public Tile targetTile;
    void Update() {
        if (Input.GetMouseButtonUp(0)) {
            // ignore if ray hits ui
            if (EventSystem.current.IsPointerOverGameObject()) {
                return;
            }
            Ray mouseRay = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out var hitInfo)) {
                
                if (hitInfo.collider.gameObject.TryGetComponent<Tile>(out var tile)) {
                    if (targetTile is not null) {
                        targetTile.selected = false;
                    }
                    targetTile = tile;
                    targetTile.selected = true;
                    return;
                }
                if (hitInfo.collider.gameObject.TryGetComponent<ITileBuilding>(out var building)) {
                    if (targetTile is not null) {
                        targetTile.selected = false;
                    }
                    targetTile = building.Parent;
                    targetTile.selected = true;
                    return;
                }
                return;
            }
            if (targetTile is not null) {
                targetTile.selected = false;
            }
            targetTile = null;
        }
    }
}
