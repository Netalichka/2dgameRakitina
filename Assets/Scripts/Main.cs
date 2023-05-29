using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{

    public class Main : MonoBehaviour
    {

        [SerializeField] private InteractiveObjectView _playerView;
        [SerializeField] private CanonView _cannonView;
        [SerializeField]
         private AIConfig _config;

        [SerializeField]
        private EnemyView _enemyView;

        private PlayerController _playerController;
        private CannonController _cannonController;
        private EmitterController _emitterController;
        private SimplePatrolAI _simplePatrolAI;

        // private AnimationConfig _config; 
        //private SpriteAnimatorController _playerAnimator;

        private void Awake()
        {
            _playerController = new PlayerController(_playerView);
            _cannonController = new CannonController(_cannonView._muzzleT, _playerView._transform);
            _emitterController = new EmitterController(_cannonView._bullets, _cannonView._emitterT);
            _simplePatrolAI = new SimplePatrolAI(_enemyView, new SimplePatrolAIModel(_config));

            // _config = Resources.Load<AnimationConfig>("SpriteAnimatorCfg");
            //_playerAnimator = new SpriteAnimatorController(_config);
            //_playerAnimator.StartAnimation(_playerView._spriteRenderer, AnimState.Run, true, 10f);
        }
        
        void Update()
        {
            _playerController.Update();
            _cannonController.Update();
            _emitterController.Update();
            //_playerAnimator.Update();
        }
    }
}
