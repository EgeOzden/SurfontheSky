using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem effect;
    float delay = 1.25f;


        void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Player"){
                effect.Play();
                Invoke("FinishControl", delay);
            }
        }

        void FinishControl(){
                Debug.Log("Tebrikler kazandınız.");
                SceneManager.LoadScene(0);  //Scenemager class, using UnityEngine.SceneManagement namespaceinden geldi. 0. indexteki scene yükle denildi.
        }

}

