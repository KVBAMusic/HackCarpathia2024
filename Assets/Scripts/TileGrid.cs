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
    private List<Tile> tiles = new();
    void Awake() {
        
    }

    public void Generate() {
        GameObject tileObj;
        Tile tile;
        for (int x = 0; x < width; x++) {
            for (int z = 0; z < length; z++) {
                tileObj = Instantiate(tilePrefab, transform);
                tileObj.transform.position = new Vector3(x * tileSize, 0f, z * tileSize) + startPos;
                tile = tileObj.GetComponent<Tile>();
                tile.Pos = new Vector2Int(x, z);
                tiles.Add(tile);
            }
        }
    }

    // Update is called once per frame
    void Update() {
    }
}
