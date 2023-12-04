using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteract : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public void Interact()
    {
        SceneManager.LoadScene(sceneName);
    }
}
