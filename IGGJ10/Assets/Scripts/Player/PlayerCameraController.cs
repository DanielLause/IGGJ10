using UnityEngine;
using System.Collections.Generic;

public class PlayerCameraController : MonoBehaviour
{
    public Transform ToFollow;
    public float CamLerpSpeed = 25;

    public float sensitivityX = 3F;
    public float sensitivityY = 3F;
    public float minimumX = -340F;
    public float maximumX = 340F;
    public float minimumY = -60F;
    public float maximumY = 60F;

    private float rotationX = 0F;
    private float rotationY = 0F;

    private Quaternion originalRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * sensitivityX;
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = ClampAngle(rotationY, minimumY, maximumY);
        Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);

        Quaternion wantedRot = originalRotation * xQuaternion * yQuaternion;
        Camera.main.transform.localRotation = Quaternion.Lerp(Camera.main.transform.localRotation, wantedRot, CamLerpSpeed * Time.deltaTime);
        Camera.main.transform.position = ToFollow.position;
    }

    private static float ClampAngle(float angle, float min, float max)
    {
        return Mathf.Clamp(angle, min, max);
    }
}
