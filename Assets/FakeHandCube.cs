using UnityEngine;

public class FakeHandCube : MonoBehaviour
{
    public Camera arCamera;  // drag AR Camera here in Inspector

    void Update()
    {
        if (arCamera == null) return;

        // Calculate position in front of camera, slightly lower (like a hand)
        transform.position =
            arCamera.transform.position +
            arCamera.transform.forward * 0.4f +
            arCamera.transform.up * -0.1f;

        // Make cube face the camera
        transform.rotation = Quaternion.LookRotation(
            transform.position - arCamera.transform.position
        );
    }
}
