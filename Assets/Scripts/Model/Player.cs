using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Model
{
    public class Player
    {
        public ReactiveProperty<float> MoveSpeed;
        public Player()
        {
            MoveSpeed = new ReactiveProperty<float>(10f);
        }
    }
}

