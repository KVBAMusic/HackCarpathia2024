using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector2Int Pos;
    private ITileBuilding _building;
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

    private Color colorBase = new(.55f, .77f, .36f);
    // Start is called before the first frame update
    void Start() {
        mat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update() {
        if (selected) {
            mat.color = Color.Lerp(colorBase, Color.white, Mathf.Abs(Mathf.Sin(Time.time)));
        }
        else {
            mat.color = colorBase;
        }
    }
}
