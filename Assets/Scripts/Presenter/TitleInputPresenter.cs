using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Presenter
{
    public class TitleInputPresenter : MonoBehaviour
    {
        // View
        [SerializeField]
        View.TitleInput _titleInputView;

        // Model
        Model.Scene _sceneModel;
        Model.TitleInput _titleInputModel;

        // 初期化
        public void Initialize(Model.Scene sceneModel, Model.TitleInput titleInputModel)
        {
            // Modelの生成
            _sceneModel = sceneModel;
            _titleInputModel = titleInputModel;

            Bind();
            SetEvents();
        }

        //Modelの値の変更を監視
        void Bind()
        {
            _titleInputModel.Start
                .Skip(1)
                .Subscribe((_) =>
                {
                    if (_) _sceneModel.CurrentSceneName.Value = Model.Scene.SceneNames.InGame.ToString();
                })
                .AddTo(gameObject);

        }

        //Viewのイベントの設定
        void SetEvents()
        {
            _titleInputView.onStartAction = TitleInputViewOnStart;
            _titleInputView.offStartAction = TitleInputViewOffStart;
        }

        void TitleInputViewOnStart()
        {
            _titleInputModel.Start.Value = true;
        }
        void TitleInputViewOffStart()
        {
            _titleInputModel.Start.Value = false;
        }
    }
}


