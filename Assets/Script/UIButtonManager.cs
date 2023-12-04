using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonManager : MonoBehaviour
{
    // [SerializeField] private GameObject containerGameObject;
    // [SerializeField] private PlayerInteract playerInteract;

    [SerializeField] private string sceneName;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))    
        {
            SceneManager.LoadScene(sceneName);
        }


        // if (playerInteract.GetInteractableObject() != null)
        // {
        //     Show();
        // }
        // else
        // {
        //     Hide();
        // }
    }

    // private void Show()
    // {
    //     containerGameObject.SetActive(true);
    // }
    // private void Hide()
    // {
    //     containerGameObject.SetActive(false);
    // }
}
