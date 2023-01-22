using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Presenter
{
    public class TitleScenePresenter : MonoBehaviour
    {
        //Presenter
        [SerializeField]
        Presenter.TitleInputPresenter _titleInputPresenter;
        [SerializeField]
        Presenter.ScenePresenter _scenePresenter;

        // Model
        Model.Scene _sceneModel;
        Model.TitleInput _titleInputModel;

        // 初期化
        void Awake()
        {
            // Modelの生成
            _sceneModel = new Model.Scene(Model.Scene.SceneNames.Start.ToString());
            _titleInputModel = new Model.TitleInput();

            //Presenterの初期化
            _titleInputPresenter.Initialize(_sceneModel, _titleInputModel);
            _scenePresenter.Initialize(_sceneModel);

        }
    }
}


