using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PlatformerMVC
{
    public enum StoryType
    {
        Common,
        Resettable
    }

    [CreateAssetMenu(fileName = "QuestStoryCfg", menuName = "Configs / QuestSystem / QuestStoryCfg", order = 1)]
    public class QuestStoryConfig : ScriptableObject
    {
        public QuestConfig[] questsConfig;
        public QuestType type;
    }
}
