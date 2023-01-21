using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Model
{
    public class Scene
    {
        public enum SceneNames : byte
        {
            Start,
            InGame
        }

        public ReactiveProperty<string> CurrentSceneName;

        public Scene(string name)
        {
            CurrentSceneName = new ReactiveProperty<string>(name);
        }
    }
}

