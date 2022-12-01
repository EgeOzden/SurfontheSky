using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    float delay = 1f;
    [SerializeField] Collider2D head;       //bu değişkene unityde kafaya koyduğumuz daire collider atandı.
    [SerializeField] Collider2D board;      //bu değişkene unityde sörftahtasına koyduğumuz kapsül collider atandı.
    [SerializeField] ParticleSystem particaleffect;
    [SerializeField] AudioClip crashsound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){       
            if(other.otherCollider == head){     //burada diğer collider variantı bizim atadığımız değerde mi kontrol edildi. 
                particaleffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashsound); //playoneshot ile serializefield atandı.
                Invoke("Kaybettin" , delay);
            }
        }
    }

    void Kaybettin(){
            Debug.Log("Kaza Yaptınız.");        //Birden fazla colliderı ayırt etmek için kullandık. Hangisiyle temas ediliyor??
            SceneManager.LoadScene(0);
    }

}
