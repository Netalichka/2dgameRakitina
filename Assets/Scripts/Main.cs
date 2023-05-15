using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{

    public class Main : MonoBehaviour
    {

        [SerializeField] private LevelObjectView _playerView;
        private PlayerController _playerController;
       // private AnimationConfig _config;
        //private SpriteAnimatorController _playerAnimator;

        private void Awake()
        {
            _playerController = new PlayerController(_playerView);
           // _config = Resources.Load<AnimationConfig>("SpriteAnimatorCfg");
            //_playerAnimator = new SpriteAnimatorController(_config);
            //_playerAnimator.StartAnimation(_playerView._spriteRenderer, AnimState.Run, true, 10f);
        }
        
        void Update()
        {
            _playerController.Update();
            //_playerAnimator.Update();
        }
    }
}
