using UnityEngine;
using System.Collections;

public class CharDetect : MonoBehaviour {

    public Collider2D interactTarget;

	void OnTriggerEnter2D(Collider2D other)
    {
        //Need to make this get the object and/or character??
        interactTarget = other;
        EventManager.TriggerEvent("setInteract");
        Debug.Log("hit");
        if (other.tag == "NPC")
        {
        }
        if(other.tag == "Item")
        {

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        EventManager.TriggerEvent("setInteract");
        interactTarget = null;

    }
}
