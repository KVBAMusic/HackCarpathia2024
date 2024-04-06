using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public new Camera camera;
    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonUp(0)) {
            Ray mouseRay = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out var hitInfo)) {
                if (hitInfo.collider.gameObject.TryGetComponent<Tile>(out var tile)) {
                    Debug.Log(tile.Pos);
                    return;
                }
                return;
            }
            Debug.Log("Not hit");
        }
    }
}
