using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public CursorManager cursor;

    public GameObject farmPrefab;
    public GameObject coalPlantPrefab;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Q)) {
            TrySpawn(farmPrefab);
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            TrySpawn(coalPlantPrefab);
        }
        if (Input.GetKeyDown(KeyCode.X)) {
            TryDestroy();
            
        }
    }

    void TrySpawn(GameObject prefab) {
        if (!cursor.targetTile.Free) {
            return;
        }

        GameObject buildingObj = Instantiate(prefab, cursor.targetTile.transform);
        buildingObj.transform.localPosition = new(0, 0.5f, 0);

        ITileBuilding building = buildingObj.GetComponent<ITileBuilding>();
        cursor.targetTile.building = building;
    }

    void TryDestroy() {
        if (cursor.targetTile.Free) {
            return;
        }

        Destroy(cursor.targetTile.transform.GetChild(0).gameObject);
        cursor.targetTile.building = null;
    }
}
