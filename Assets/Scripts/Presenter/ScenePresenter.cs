using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Presenter
{
    public class ScenePresenter : MonoBehaviour
    {
        // View
        [SerializeField]
        View.Scene _sceneView;

        // Model
        Model.Scene _sceneModel;

        // 初期化
        public void Initialize(Model.Scene sceneModel)
        {
            // Modelの生成
            _sceneModel = sceneModel;

            Bind();
            SetEvents();
        }

        //Modelの値の変更を監視
        void Bind()
        {
            _sceneModel.CurrentSceneName
                .Skip(1)
                .Subscribe((_) => { _sceneView.ChangeScene(_); })
                .AddTo(gameObject);
        }

        //Viewのイベントの設定
        void SetEvents()
        {
        }
    }
}


