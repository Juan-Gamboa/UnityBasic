using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{

    public bool isPickable = true;
   

    private void OnTriggerEnter(Collider other){
        if(other.tag == "PlayerInteractionZone"){
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
            AudioManager.Instance.Play2D("Detectar");
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.tag == "PlayerInteractionZone"){
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
        }
    }
}
