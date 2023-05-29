using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{



    public class SimplePatrolAIModel
    {
        private AIConfig _config;
        private Transform _target;
        private int _currentPointIndex;

        public SimplePatrolAIModel(AIConfig config)
        {
            _config = config;
            _target = GetNextWaypoint();
        }

        public Vector2 CalculateVelocity(Vector2 fromPosition)
        {
            var distance = Vector2.Distance(_target.position, fromPosition);
            if (distance <= _config.MinDistanceToTarget)
                _target = GetNextWaypoint();

            var direction = ((Vector2)_target.position - fromPosition).normalized;
            return _config.Speed * direction;
        }
        private Transform GetNextWaypoint()
        {
            _currentPointIndex = (_currentPointIndex + 1) % _config.WayPoints.Length;
            return _config.WayPoints[_currentPointIndex];
        }
    }
}
