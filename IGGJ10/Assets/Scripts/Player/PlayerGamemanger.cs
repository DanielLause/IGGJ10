using UnityEngine;
using System.Collections;

public class PlayerGamemanger : MonoBehaviour
{
    private PlayerMovementController playerMovementController;

    void Awake()
    {
        playerMovementController = GetComponent<PlayerMovementController>();
    }
}
