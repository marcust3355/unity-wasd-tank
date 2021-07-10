using UnityEngine;


public class CameraController : MonoBehaviour
{
    public float rotateSpeed = 90.0f;
    public float speed = 5.0f;

    private void Update()
    {
        float transAmount = speed * Time.deltaTime;
        float rotateAmount = rotateSpeed * Time.deltaTime;


        if (Input.GetKey(KeyCode.W)) {
        transform.Translate(0, 0, transAmount);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(0, 0, -transAmount);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, -rotateAmount, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, rotateAmount, 0);
        }
    }
}
