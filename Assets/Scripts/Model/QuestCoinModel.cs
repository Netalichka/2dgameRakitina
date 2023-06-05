using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PlatformerMVC
{

    public class QuestCoinModel : IQuestModel
    {
        public bool TryComplete(GameObject actor)
        {
            return actor.CompareTag("QuestCoin");
        }
    }
}
