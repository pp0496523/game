using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Presenter
{
    public class InGameScenePresenter : MonoBehaviour
    {

        // View
        [SerializeField]
        View.PlayerView _playerView;
        [SerializeField]
        View.PlayerInputView _playerInputView;

        // Model
        Model.Player _playerModel;
        Model.PlayerInput _playerInputModel;

        // 初期化
        void Awake()
        {
            // Modelの生成
            _playerModel = new Model.Player();
            _playerInputModel = new Model.PlayerInput();

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
            _playerInputView.OnPlayerMoveAction = PlayerViewOnPlayerMovetAction;
            _playerInputView.CancelPlayerMovetAction = PlayerViewCancelPlayerMovetAction;
        }

        void PlayerViewOnPlayerMovetAction(Vector2 vector2)
        {
            _playerInputModel.Moved.Value = vector2;
        }
        void PlayerViewCancelPlayerMovetAction(Vector2 vector2)
        {
            _playerInputModel.Moved.Value = vector2;
        }

        //update
        void FixedUpdate()
        {
            _playerView.Move(_playerInputModel.Moved.Value, _playerModel.MoveSpeed.Value);
        }
    }
}


