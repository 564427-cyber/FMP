using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f; //how far away you need to be tobe able to interact
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange); //creates an array for interact range.
            foreach (Collider collider in colliderArray) //lists the colliders in the array
            {
                if(collider.TryGetComponent(out NPCInteractable npcInteractable))
                {
                    npcInteractable.Interact();
                }
            }
            
        }
    }

    public NPCInteractable GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent( out NPCInteractable npcInteractable))
            {
                return npcInteractable;
            }
        }
        return null; // does the same thing as the method above but it returns it as null
    }


}
