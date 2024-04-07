using UnityEngine;

public class Rotate : MonoBehaviour {
    public Vector3 angles;
    private Quaternion rotDelta;

    void Update() {
        rotDelta = Quaternion.Euler(angles * Time.deltaTime);
        transform.rotation *= rotDelta;
    }
}