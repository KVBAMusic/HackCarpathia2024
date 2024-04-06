using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public CursorManager cursor;

    public GameObject farmPrefab;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!cursor.targetTile.Free) {
                return;
            }

            GameObject buildingObj = Instantiate(farmPrefab, cursor.targetTile.transform);
            buildingObj.transform.localPosition = new(0, 0.5f, 0);

            ITileBuilding building = buildingObj.GetComponent<ITileBuilding>();
            cursor.targetTile.building = building;

        }
    }
}
