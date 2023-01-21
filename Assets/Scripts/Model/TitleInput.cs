using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Model
{
    public class TitleInput
    {
        public ReactiveProperty<bool> Start;
        public TitleInput()
        {
            Start = new ReactiveProperty<bool>(false);
        }
    }
}

