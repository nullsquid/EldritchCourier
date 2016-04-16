using UnityEngine;
using System.Collections;

public class CharInteract : MonoBehaviour {

    private bool canInteract;
    public Collider2D interactTarget;

    void OnEnable()
    {
        EventManager.StartListening("setInteract", SetInteract);
    }

    void OnDisable()
    {
        EventManager.StopListening("setInteract", SetInteract);
    }

    void SetInteract()
    {
        canInteract = !canInteract;
        if (canInteract)
        {
            interactTarget = GetComponentInChildren<CharDetect>().interactTarget;
        }
        else
        {
            interactTarget = null;
        }
        Debug.Log(canInteract);
    }

    void Update()
    {
        if (!canInteract)
        {
            interactTarget = null;
        }
        else if (canInteract)
        {
            //for testing purposes
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interact");
                //interactTarget.GetComponent<Character>().Interact();
                //interactTarget.GetComponent<Character>().Interact();
                interactTarget.GetComponent<Character>().Interact(interactTarget.GetComponent<Character>()._name);
            }
        }
    }

	
}
