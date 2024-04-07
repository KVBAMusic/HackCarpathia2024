using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public CursorManager cursor;

    public GameObject farmPrefab;
    public GameObject coalPlantPrefab;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.X)) {
            TryDestroy();

        }
    }

    public void TrySpawn(GameObject prefab) {
        if (cursor.targetTile is null) {
            Audio.BuildFailed();
            return;
        }
        if (!cursor.targetTile.Free) {
            Audio.BuildFailed();
            return;
        }
        if (!prefab.GetComponent<ITileBuilding>().PlacedOn.Contains(cursor.targetTile.tileType)) {
            Audio.BuildFailed();
            return;
        }
        if (prefab.GetComponent<ITileBuilding>().Cost > GameState.State.Money) {
            Audio.BuildFailed();
            return;
        }

        GameObject buildingObj = Instantiate(prefab, cursor.targetTile.transform);
        buildingObj.transform.localPosition = new(0, 0.5f, 0);

        ITileBuilding building = buildingObj.GetComponent<ITileBuilding>();
        GameState.State.Money -= building.Cost;

        cursor.targetTile.building = building;
        cursor.targetTile.Animate();
    }

    public void TryDestroy() {
        if (cursor.targetTile is null) {
            return;
        }
        if (cursor.targetTile.Free) {
            return;
        }

        Destroy(cursor.targetTile.transform.GetChild(0).gameObject);
        cursor.targetTile.building = null;
    }
}
