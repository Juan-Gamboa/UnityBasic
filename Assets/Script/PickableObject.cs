using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{

    public bool isPickable = true;
    public GameObject sonido;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "PlayerInteractionZone"){
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
            AudioManager.Instance.Play3D("Aldeano3D",sonido.transform.position);
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.tag == "PlayerInteractionZone"){
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
        }
    }
}
