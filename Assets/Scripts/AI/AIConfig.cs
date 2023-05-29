using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PlatformerMVC
{



    [SerializeField]

    public struct AIConfig
    {
        public float Speed;
        public float MinDistanceToTarget;
        public Transform[] WayPoints;
    }
}
