using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sepay.Nugie {
    public class MaterialHandler : MonoBehaviour
    {
        public Material[] environmentAR;
        Renderer rend;

        // Start is called before the first frame update
        void Start()
        {
            rend = GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = environmentAR[0];
        }

        public void Sains3Material() {
            rend.sharedMaterial = environmentAR[0];
        }

        public void AltarUtamaMaterial() {
            rend.sharedMaterial = environmentAR[1];
        }

        public void BrauMaterial() {
            rend.sharedMaterial = environmentAR[2];
        }

        public void Brau2Material() {
            rend.sharedMaterial = environmentAR[3];
        }

        public void Brau4Material() {
            rend.sharedMaterial = environmentAR[4];
        }

        public void CandiKembarMaterial() {
            rend.sharedMaterial = environmentAR[5];
        }

        public void CandiKembar2Material() {
            rend.sharedMaterial = environmentAR[6];
        }

        public void CandiDepanPenataranMaterial() {
            rend.sharedMaterial = environmentAR[7];
        }

        public void GapuraMaterial() {
            rend.sharedMaterial = environmentAR[8];
        }

        public void Gapura2Material() {
            rend.sharedMaterial = environmentAR[9];
        }

        public void Gapura3Material() {
            rend.sharedMaterial = environmentAR[10];
        }

        public void JoloMaterial() {
            rend.sharedMaterial = environmentAR[11];
        }

        public void MgerabahMaterial() {
            rend.sharedMaterial = environmentAR[12];
        }

        public void Marca1Material() {
            rend.sharedMaterial = environmentAR[13];
        }

        public void Marca2Material() {
            rend.sharedMaterial = environmentAR[14];
        }

        public void Marca3Material() {
            rend.sharedMaterial = environmentAR[15];
        }

        public void Marca4Material() {
            rend.sharedMaterial = environmentAR[16];
        }

        public void Marca5Material() {
            rend.sharedMaterial = environmentAR[17];
        }

        public void MguciMaterial() {
            rend.sharedMaterial = environmentAR[18];
        }

        public void KeramikMaterial() {
            rend.sharedMaterial = environmentAR[19];
        }

        public void LempenganNaskahMaterial() {
            rend.sharedMaterial = environmentAR[20];
        }

        public void PrasastiMaterial() {
            rend.sharedMaterial = environmentAR[21];
        }

        public void ReliefMaterial() {
            rend.sharedMaterial = environmentAR[22];
        }

        public void MrumahMajapahitMaterial() {
            rend.sharedMaterial = environmentAR[23];
        }

        public void MenujuAltarMaterial() {
            rend.sharedMaterial = environmentAR[24];
        }

        public void PadepokanJMaterial() {
            rend.sharedMaterial = environmentAR[25];
        }

        public void Pemujaan1Material() {
            rend.sharedMaterial = environmentAR[26];
        }

        public void PenataranDepanMaterial() {
            rend.sharedMaterial = environmentAR[27];
        }

        public void SegaranMaterial() {
            rend.sharedMaterial = environmentAR[28];
        }

        public void SimpingMaterial() {
            rend.sharedMaterial = environmentAR[29];
        }

        public void TarcaMaterial() {
            rend.sharedMaterial = environmentAR[30];
        }

        public void TbudayaMaterial() {
            rend.sharedMaterial = environmentAR[31];
        }

        public void TgerabahMaterial() {
            rend.sharedMaterial = environmentAR[32];
        }

        public void TsainsMaterial() {
            rend.sharedMaterial = environmentAR[33];
        }

        public void Tsains2Material() {
            rend.sharedMaterial = environmentAR[34];
        }

        public void TseniMaterial() {
            rend.sharedMaterial = environmentAR[35];
        }

        public void Tseni2Material() {
            rend.sharedMaterial = environmentAR[36];
        }

        public void TteaterMaterial() {
            rend.sharedMaterial = environmentAR[37];
        }

        public void TfosilMaterial() {
            rend.sharedMaterial = environmentAR[38];
        }

        public void TpustakaMaterial() {
            rend.sharedMaterial = environmentAR[39];
        }

        public void TerasJMaterial() {
            rend.sharedMaterial = environmentAR[40];
        }

        public void TetekMaterial() {
            rend.sharedMaterial = environmentAR[41];
        }

        public void TikusMaterial() {
            rend.sharedMaterial = environmentAR[42];
        }

        public void Tikus2Material() {
            rend.sharedMaterial = environmentAR[43];
        }

        public void WringinMaterial() {
            rend.sharedMaterial = environmentAR[44];
        }

        public void Wringin2Material() {
            rend.sharedMaterial = environmentAR[45];
        }
    }
}
