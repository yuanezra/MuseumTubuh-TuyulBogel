using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;
    [SerializeField] private float interactRanges = 10f;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
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
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, interactableLayer))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            return hit.transform.gameObject.GetComponent<ObjectInteract>();
        }

        return null;
    }
}
