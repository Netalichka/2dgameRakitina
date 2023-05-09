using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{

    public class Main : MonoBehaviour
    {

        [SerializeField] private AnimationConfig _config;
        private SpriteAnimatorController _playerAnimator;

        private void Awake()
        {
            _config = Resources.Load<AnimationConfig>("SpriteAnimatorCfg");
            _playerAnimator = new SpriteAnimatorController(_config);
            //_playerAnimator
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
