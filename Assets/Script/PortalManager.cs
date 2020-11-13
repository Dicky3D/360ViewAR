using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sepay.Nugie
{
    public class PortalManager : MonoBehaviour
    {
        public GameObject MainCamera;

        public GameObject Material360;
        
        public GameObject PortalView;

        private Material[] SponzaMaterials;

        // Start is called before the first frame update
        void Start()
        {
            SponzaMaterials = Material360.GetComponent<Renderer>().sharedMaterials;
            PortalView.SetActive(true);
        }

        private void OnTriggerEnter(Collider collider)
        {
            Vector3 camPos = transform.InverseTransformPoint(MainCamera.transform.position); 

            if(camPos.y < 0.5f) {
                for(int i = 0; i < SponzaMaterials.Length; ++i) {
                    SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Always);
                    PortalView.SetActive(false);
                }
            }
            else
            {
                for(int i = 0; i < SponzaMaterials.Length; ++i) {
                    SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
                    PortalView.SetActive(true);
                }
            }
        }
    }    
}
