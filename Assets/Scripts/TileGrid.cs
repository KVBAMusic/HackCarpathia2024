using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public uint width = 8;
    public uint length = 8;
    public float tileSize = 2.1f;
    [Range(0,1)]
    public float lowGroundThreshold = .3f;
    [Range(0,1)]
    public float highGroundThreshold = .7f;
    public Vector3 startPos;
    public GameObject tilePrefab;
    private static List<Tile> tiles = new();
    void Awake() {
        Generate();
        float value;
        float currentTime = DateTime.Now.Millisecond / 1000f + DateTime.Now.Second + DateTime.Now.Minute * 60;
        float scale = 3;
        Debug.Log($"There are {tiles.Count} tiles");
        foreach (Tile tile in tiles) {
            value = Mathf.PerlinNoise(currentTime + tile.Pos.x * scale / width, currentTime + tile.Pos.y * scale / length);
            Debug.Log($"Tile ${tile.Pos} - {value}"); 
            if (value < lowGroundThreshold) {
                tile.tileType = TileType.Water;
            }
            else if (value < highGroundThreshold) {
                tile.tileType = TileType.Ground;
            }
            else {
                tile.tileType = TileType.Barren;
            }
        }
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

    #if UNITY_EDITOR
    public void GenerateEditor() {
        for (int i = 0; i < transform.childCount; i++) {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
        Generate();
    }
    #endif

    public static Tile[] GetNeighboursByType(Tile origin, TileType type) {
        return tiles.Where(t => Vector2Int.Distance(t.Pos, origin.Pos) == 1)
                    .Where(t => t.tileType == type)
                    .ToArray();
    }

    public static Tile[] GetNeighboursByBuilding<T>(Tile origin) where T : ITileBuilding{
        return tiles.Where(t => Vector2Int.Distance(t.Pos, origin.Pos) == 1)
                    .Where(t => t.building?.GetType() == typeof(T))
                    .ToArray();
    }

    public static void AdvanceAll() {
        tiles.ForEach(t => t.Advance());
    }
}
