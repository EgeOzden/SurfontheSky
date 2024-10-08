using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEffect : MonoBehaviour
{

    [SerializeField] ParticleSystem effect;
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            effect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.tag == "Ground"){
            effect.Stop();
        }
    }

}
