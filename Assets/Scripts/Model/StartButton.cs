using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Model
{
    public class StartButton
    {
        public ReactiveProperty<bool> Started;
        public StartButton()
        {
            Started = new ReactiveProperty<bool>(false);
        }
    }
}

