using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sepay.Nugie
{
    public class PortalManager : MonoBehaviour
    {
        public GameObject MainCamera;

        public GameObject Sponza;
        
        public Material[] SponzaMaterials;

        // Start is called before the first frame update
        void Start()
        {
            SponzaMaterials = Sponza.GetComponent<Renderer>().sharedMaterials;
        }

        private void OnTriggerEnter(Collider collider)
        {
            Vector3 camPos = transform.InverseTransformPoint(MainCamera.transform.position); 

            if(camPos.y < 0.5f && collider.gameObject.tag == "Main Camera") {
                for(int i = 0; i < SponzaMaterials.Length; ++i) {
                    SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Always);
                }
            }
            else
            {
                for(int i = 0; i < SponzaMaterials.Length; ++i) {
                    SponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
                }
            }   
        }
    }    
}
