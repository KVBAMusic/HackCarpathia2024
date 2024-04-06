using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector2Int Pos;
    private ITileBuilding _building = null;
    public ITileBuilding building {
        get => _building;
        set {
            _building = value;
            if (_building is not null) {
                _building.Parent = this;
            }
        }
    }

    public bool Free => building is null;
    public bool selected = false;
    private Material mat;


    private Color colorGround = new(.55f, .77f, .36f);
    private Color colorBarren = new(.77f, .68f, .36f);
    private Color colorWater = new(.35f, .77f, .77f);

    public TileType tileType = TileType.Ground;
    private Color currentColor => tileType switch {
        TileType.Water => colorWater,
        TileType.Ground => colorGround,
        TileType.Barren => colorBarren,
        _ => Color.black,
    };

    public new AnimationCurve animation;
    private Vector3 targetScale;
    private float animTime = 0;
    public float animSpeed = 2;

    void Start() {
        mat = GetComponent<MeshRenderer>().material;
        targetScale = transform.localScale;
    }

    void Update() {
        if (selected) {
            mat.color = Color.Lerp(currentColor, Color.white, Mathf.Abs(Mathf.Sin(Time.time * 2)));
        }
        else {
            mat.color = currentColor;
        }
        animTime += Time.deltaTime;
        transform.localScale = Vector3.LerpUnclamped(Vector3.zero, targetScale, animation.Evaluate(animTime * animSpeed));
    }

    public void Advance() {
        building?.Advance();
        if (tileType == TileType.Barren) {
            int forestTiles = TileGrid.GetNeighboursByBuilding<Forest>(this).Length;
            if (forestTiles >= 2) {
                tileType = TileType.Ground;
            }
            else if (forestTiles == 1) { 
                if (Random.Range(0, 4) == 0) {
                    tileType = TileType.Ground;
                }
            }
        }
    }

    public void Animate() {
        animTime = 0;
    }
}
