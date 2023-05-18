using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{

    public class PlayerController 
    {
        private AnimationConfig _config;
        private SpriteAnimatorController _playerAnimator;
        private ContactsPooler _contactPooler;
        private LevelObjectView _playerView;

        private Transform _playerT;
        private Rigidbody2D _rb;


        private float _xAxisInput;
        private bool _isJump;

        private float _walkSpeed = 200f;
        private float _animationSpeed = 10f;
        private float _movingTreshold = 0.1f;

        private Vector3 _leftScale = new Vector3(-1, 1, 1);
        private Vector3 _rightScale = new Vector3(1, 1, 1);

        private bool _isMoving;

        private float _jumpForce = 9f;
        private float _jumpTreshold = 0.5f;
        //private float _g = -9.8f;
        //private float _groundLevel = -2.45f;
        private float _yVelocity;
        private float _xVelocity;





       public PlayerController(LevelObjectView player)
        {
            _config = Resources.Load<AnimationConfig>("SpriteAnimatorCfg");
            _playerAnimator = new SpriteAnimatorController(_config);
            _playerAnimator.StartAnimation(player._spriteRenderer, AnimState.Run, true, _animationSpeed);
            _contactPooler = new ContactsPooler(player._collider);
            _playerView = player;
            _playerT = player._transform;
            _rb = player._rb;
        }

        private void MoveTowards()
        {
            _xVelocity = Time.deltaTime * _walkSpeed * (_xAxisInput < 0 ? -1 : 1);
            _rb.velocity = new Vector2(_xVelocity, _yVelocity);
            _playerT.localScale = _xAxisInput < 0 ? _leftScale : _rightScale;

        }

        //public bool IsGrounded()
        //{
         //   return _playerT.position.y <= _groundLevel && _yVelocity <= 0;

        //}
        
        public void Update()
        {
            _playerAnimator.Update();
            _contactPooler.Update();
            _xAxisInput = Input.GetAxis("Horizontal");
            _isJump = Input.GetAxis("Vertical") > 0;
            _yVelocity = _rb.velocity.y;
            _isMoving = Mathf.Abs(_xAxisInput) > _movingTreshold;
            _playerAnimator.StartAnimation(_playerView._spriteRenderer, _isMoving ? AnimState.Run : AnimState.Idle, true, _animationSpeed);

            if (_isMoving)
            {
                MoveTowards();
            }

            else
            {
                _xVelocity = 0;
                _rb.velocity = new Vector2(_xVelocity, _rb.velocity.y);
            }

            if (_contactPooler.IsGrounded)
            {
                
                if (_isJump && _yVelocity <= _jumpTreshold)
                {
                    // _yVelocity = _jumpForce;
                    _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
                }
               // else if (_yVelocity < 0)
                //{
                    //_yVelocity = 0;
                    //_playerT.position = new Vector3(_playerT.position.x, _groundLevel, _playerT.position.z);

               // }
                    
            }

            else
            {
                if (Mathf.Abs(_yVelocity) > _jumpTreshold)
                {
                    _playerAnimator.StartAnimation(_playerView._spriteRenderer, AnimState.Jump, true, _animationSpeed);
                }
                //_yVelocity += _g * Time.deltaTime;
                //_playerT.position += Vector3.up * (Time.deltaTime * _yVelocity);
            }
        }
    }
}
