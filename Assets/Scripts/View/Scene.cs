using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace View
{
    public class Scene : MonoBehaviour
    {
        public void ChangeScene(string name)
        {
            SceneManager.LoadScene(name);
        }
    }
}

