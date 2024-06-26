using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    
    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Player"){
            collision.gameObject.transform.SetParent(transform);
        }
    }

    public void OnCollisionExit(Collision collision){
        if(collision.gameObject.name == "Player"){
            collision.gameObject.transform.SetParent(null);
        }
    }
}
