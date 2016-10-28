using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
class DoorBehaviour : TimeShiftManager
{
    void Update()
    {
        OnUpdate();
    }

}
