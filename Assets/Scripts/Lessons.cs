using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace PlatformerMVC
//{



//    public class Lessons : MonoBehaviour
//    {

//        [SerializeField]
//        private Camera _camera;

//        [SerializeField]
//        private SpriteRenderer _background;

//        [SerializeField]
//        private CharacterView _characterView;

//        [SerializeField]
//        private SpriteAnimationConfig _spriteAnimationConfig;

//        [SerializeField]
//        private CanonView _cannonView;

//        [SerializeField]
//        private List<BulletView> _bullets;

//        [SerializeField]
//        private AIConfig _config;

//        [SerializeField]
//        private EnemyView _enemyView;

//        [SerializeField]
//        private List<CoinView> _coinViews;

//        private ParalaxManager _paralaxManager;
//        private SpriteAnimator _spriteAnimator;
//        private MainHeroWalker _mainHeroWalker;
//        private MainHeroPhysicsWalker _mainHeroPhysicsWalker;
//        private AimingMuzzle _aimingMuzzle;
//        private BulletsEmitter _bulletsEmitter;
//        private CoinsManager _coinsManager;
//        private SimplePatrolAI _simplePatrolAI;

//        // Start is called before the first frame update
//        private void Start()
//        {
//            _paralaxManager = new ParalaxManager(_camera, _background.transform);
//            _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
//            _coinsManager = new CoinsManager(_coinViews);
//            _mainHeroPhysicsWalker = new MainHeroPhysicsWalker(_characterView, _spriteAnimator);
//            _aimingMuzzle = new AimingMuzzle(_cannonView.transform, _characterView.transform);
//            _bulletsEmitter = new BulletsEmitter(_bullets, _cannonView.MuzzleTransform);
//            _simplePatrolAI = new SimplePatrolAI(_enemyView, new SimplePatrolAIModel(_config));
//        }

//        // Update is called once per frame
//        private void Update()
//        {
//            _paralaxManager.Update();
//            _spriteAnimator.Update();
//            _aimingMuzzle.Update();
//            _bulletsEmitter.Update();


//        }

//        private void FixedUpdate()
//        {
//            _mainHeroPhysicsWalker.FixedUpdate();
//            _simplePatrolAI.FixedUpdate();
//        }

//        private void OnDestroy()
//        {
//            _coinsManager.Dispose();
//        }
//    }
//}

