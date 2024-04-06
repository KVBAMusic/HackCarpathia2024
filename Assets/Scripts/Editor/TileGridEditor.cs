using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TileGrid))]
public class TileGridEditor : Editor{
    public override void OnInspectorGUI()
    {
        TileGrid target = (TileGrid)this.target;
        DrawDefaultInspector();

        if (GUILayout.Button("Generate Grid")) {
            target.Generate();
        }
    }
}