using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;
    readonly Vector3 movementUp = new(-.7f, 0f, .7f);
    readonly Vector3 movementRight = new(.7f, 0f, .7f);

    void Update() {
        transform.position += (movementUp * Input.GetAxis("Vertical") + movementRight * Input.GetAxis("Horizontal")) * speed * Time.deltaTime;
    }
}
