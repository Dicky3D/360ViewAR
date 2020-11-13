using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sepay.Nugie {
    public class Main360Manager : MonoBehaviour
    {
        public GameObject layout1, layout2, layout3, layout4;

        // Start is called before the first frame update
        void Start()
        {
            CloseLayoutAll();
        }

        void CloseLayoutAll() {
            layout1.SetActive(false);
            layout2.SetActive(false);
            layout3.SetActive(false);
            layout4.SetActive(false);
        }

        public void BackMainMenu() {
            SceneManager.LoadScene("MainMenu");
        }

        public void CloseMainMenu() {
            CloseLayoutAll();
        }

        public void MenuButtonPressed() {
            layout1.SetActive(true);
        }

        public void NextLayout1Pressed() {
            layout1.SetActive(false);
            layout2.SetActive(true);
        }

        public void NextLayout2Pressed() {
            layout2.SetActive(false);
            layout3.SetActive(true);
        }

        public void NextLayout3Pressed() {
            layout3.SetActive(false);
            layout4.SetActive(true);
        }

        public void BackLayout1Pressed() {
            layout2.SetActive(false);
            layout1.SetActive(true);
        }

        public void BackLayout2Pressed() {
            layout3.SetActive(false);
            layout2.SetActive(true);
        }

        public void BackLayout3Pressed() {
            layout4.SetActive(false);
            layout3.SetActive(true);
        }
    }
}