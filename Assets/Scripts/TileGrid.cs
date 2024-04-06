using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public uint width = 8;
    public uint length = 8;
    public float tileSize = 2.1f;
    public Vector3 startPos;
    public GameObject tilePrefab;
    void Awake() {
        GameObject tile;
        for (int x = 0; x < width; x++) {
            for (int z = 0; z < length; z++) {
                tile = Instantiate(tilePrefab, transform);
                tile.transform.position = new Vector3(x * tileSize, 0f, z * tileSize) + startPos;
                tile.GetComponent<Tile>().Pos = new Vector2Int(x, z);
            }
        }
    }

    // Update is called once per frame
    void Update() {
    }
}
