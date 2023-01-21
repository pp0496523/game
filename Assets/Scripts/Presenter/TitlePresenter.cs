using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Presenter
{
    public class TitlePresenter : MonoBehaviour
    {
        // View
        [SerializeField]
        View.Scene _sceneView;
        [SerializeField]
        View.TitleInput _titleInputView;

        // Model
        Model.Scene _sceneModel;
        Model.TitleInput _titleInputModel;

        // 初期化
        void Awake()
        {
            // Modelの生成
            _sceneModel = new Model.Scene(Model.Scene.SceneNames.Start.ToString());
            _titleInputModel = new Model.TitleInput();

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


            _sceneModel.CurrentSceneName
                .Skip(1)
                .Subscribe((_) => { _sceneView.ChangeScene(_); })
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


