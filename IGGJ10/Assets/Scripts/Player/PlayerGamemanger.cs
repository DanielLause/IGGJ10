using UnityEngine;
using System.Collections;

public class PlayerGamemanger : MonoBehaviour
{
    [HideInInspector]
    public PlayerMovementController PlayerMovementController;
    [HideInInspector]
    public PlayerCameraController PlayerCameraController;

    void Awake()
    {
        PlayerMovementController = GetComponent<PlayerMovementController>();
        PlayerCameraController = GetComponent<PlayerCameraController>();
    }
}
