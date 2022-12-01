using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]float torkdeger =3f;
    Rigidbody2D rg2d;
    SurfaceEffector2D se2d;
 
    float boostspeed = 30f;
    float normalspeed = 13f;
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>(); //aynı gameobjectteki componente müdahale
        se2d = FindObjectOfType<SurfaceEffector2D>(); //farklı componente müdahale
    }

    void Update()
    {
        DonusKontrolu();
        BoostKontrolu();
    }

    void BoostKontrolu(){
        if(Input.GetKey(KeyCode.W)){
            se2d.speed = boostspeed;
        }
        else{
            se2d.speed = normalspeed;
        }
        
    }

    void DonusKontrolu(){
        if(Input.GetKey(KeyCode.A)){    //Input.getkey ile tuş okunur. A tuştur
            rg2d.AddTorque(torkdeger);  //Tork dönüş değeri ekler.
        }
        else if(Input.GetKey(KeyCode.D)){
            rg2d.AddTorque(-torkdeger); // ters yön için - koyuldu (-1)
        }
    }
}
