using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[SerializeField]

public struct AIConfig 
{
    public float Speed;
    public float MinDistanceToTarget;
    public Transform[] WayPoints;
}
