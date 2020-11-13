using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sepay.Nugie {
    public class MainMenuManager : MonoBehaviour
    {
        private void Update() {
            if(Input.GetKey(KeyCode.Escape)) {
                Application.Quit(0);
            }
        }

        public void MenuStart() {
            SceneManager.LoadScene("Main360");
        }

        public void MenuExit() {
            Application.Quit(0);
        }
    }
}
