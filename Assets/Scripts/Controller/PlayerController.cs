using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{

    public class PlayerController 
    {
        private AnimationConfig _config;
        private SpriteAnimatorController _playerAnimator;
        private LevelObjectView _playerView;


        private float _xAxisInput;
        private bool _isJump;

        private float _walkSpeed = 3f;
       public PlayerController(LevelObjectView player)
        {
            _config = Resources.Load<AnimationConfig>("SpriteAnimatorCfg");
            _playerAnimator = new SpriteAnimatorController(_config);
            _playerAnimator.StartAnimation(player._spriteRenderer, AnimState.Run, true, 10f);
            _playerView = player;
        }
        // Update is called once per frame
        public void Update()
        {
            _playerAnimator.Update();
        }
    }
}
