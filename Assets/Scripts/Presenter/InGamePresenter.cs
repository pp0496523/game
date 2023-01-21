using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Presenter
{
    public class InGamePresenter : MonoBehaviour
    {
        // View
        [SerializeField]
        View.PlayerInput _playerInput;

        // Model


        // 初期化
        void Awake()
        {
            // Modelの生成

            Bind();
            SetEvents();
        }

        //Modelの値の変更を監視
        void Bind()
        {

        }

        //Viewのイベントの設定
        void SetEvents()
        {
            _playerInput.OnPlayerMoveAction = PlayerViewOnPlayerMovetAction;
            _playerInput.CancelPlayerMovetAction = PlayerViewCancelPlayerMovetAction;
        }

        void PlayerViewOnPlayerMovetAction(Vector2 move)
        {
            Debug.Log(move);
        }
        void PlayerViewCancelPlayerMovetAction(Vector2 move)
        {
            Debug.Log(move);
        }
    }
}


