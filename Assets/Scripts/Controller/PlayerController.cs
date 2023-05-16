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

        private Transform _playerT;


        private float _xAxisInput;
        private bool _isJump;

        private float _walkSpeed = 3f;
        private float _animationSpeed = 10f;
        private float _movingTreshold = 0.1f;

        private Vector3 _leftScale = new Vector3(-1, 1, 1);
        private Vector3 _rightScale = new Vector3(1, 1, 1);

        private bool _isMoving;

        private float _jumpForce = 9f;
        private float _jumpTreshold = 1f;
        private float _g = -9.8f;
        private float _groundLevel = 0.5f;
        private float _yVelocity;





       public PlayerController(LevelObjectView player)
        {
            _config = Resources.Load<AnimationConfig>("SpriteAnimatorCfg");
            _playerAnimator = new SpriteAnimatorController(_config);
            _playerAnimator.StartAnimation(player._spriteRenderer, AnimState.Run, true, _animationSpeed);
            _playerView = player;
            _playerT = player._transform;
        }

        private void MoveTowards()
        {
            _playerT.position += Vector3.right * (Time.deltaTime * _walkSpeed * (_xAxisInput < 0 ? -1 : 1));
            _playerT.localScale = _xAxisInput < 0 ? _leftScale : _rightScale;

        }

        public bool IsGrounded()
        {
            return _playerT.position.y <= _groundLevel && _yVelocity <= 0;

        }
        
        public void Update()
        {
            _playerAnimator.Update();
            _xAxisInput = Input.GetAxis("Horizontal");
            _isJump = Input.GetAxis("Vertical") > 0;
            _isMoving = Mathf.Abs(_xAxisInput) > _movingTreshold;

            if (_isMoving)
            {
                MoveTowards();
            }

            if (IsGrounded())
            {
                _playerAnimator.StartAnimation(_playerView._spriteRenderer, isMoving ? AnimState.Run : AnimState.Idle, true, _animationSpeed);
                if (_isJump && _yVelocity <= 0)
                {
                    _yVelocity = _jumpForce;
                }
                else if (_yVelocity < 0)
                {
                    _yVelocity = 0;
                    _playerT.position = new Vector3(_playerT.position.x, _groundLevel, _playerT.position.z);
                }
                    
            }
        }
    }
}
