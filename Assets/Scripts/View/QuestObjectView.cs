using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PlatformerMVC
{

    public class QuestObjectView : LevelObjectView
    {
        public Color _completedColor;
        public Color _defaultColor;

        private void Awake()
        {
            _defaultColor = _spriteRenderer.color;
        }

        public void ProcessComplete()
        {
            _spriteRenderer.color = _completedColor;

        }

        public void ProcessActivate()
        {
            _spriteRenderer.color = _defaultColor;
        }
    }
}
