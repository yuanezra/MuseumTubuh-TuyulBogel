using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float interactRanges = 10f;
            Collider[] colliderArrays = Physics.OverlapSphere(transform.position, interactRanges);
            foreach (Collider collider in colliderArrays)
            {
                if (collider.TryGetComponent(out ObjectInteract objectInteractable))
                {
                    objectInteractable.Interact();
                }
            }
        }
    }

    public ObjectInteract GetInteractableObject()
    {
        float interactRanges = 10f;
        Collider[] colliderArrays = Physics.OverlapSphere(transform.position, interactRanges);
        foreach (Collider collider in colliderArrays)
        {
            if (collider.TryGetComponent(out ObjectInteract objectInteractable))
            {
                return objectInteractable;
            }
        }
        return null;
    }
}
