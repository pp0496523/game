using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Model
{
    public class PlayerInput
    {
        public Vector2ReactiveProperty Moved;
        public PlayerInput()
        {
            Moved = new Vector2ReactiveProperty(new Vector2(0, 0));
        }
    }
}

