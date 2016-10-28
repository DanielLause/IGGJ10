using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerGamemanger playerGamemanager;

    void Awake()
    {
        playerGamemanager = GetComponent<PlayerGamemanger>();
    }
}
