using UnityEngine;

public class Rotate : MonoBehaviour {
    public Vector3 angles;

    void Update() {
        transform.eulerAngles += angles * Time.deltaTime;
    }
}