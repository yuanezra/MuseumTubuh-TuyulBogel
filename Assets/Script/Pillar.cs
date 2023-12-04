using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    [SerializeField] private GameObject quizGameObject;
    [SerializeField] private MouseHover mouseHover;
    private bool isQuizActive = false;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isQuizActive) {
            quizGameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            mouseHover.IsQuizActive = true;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            isQuizActive = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            isQuizActive = false;
        }
    }
}
