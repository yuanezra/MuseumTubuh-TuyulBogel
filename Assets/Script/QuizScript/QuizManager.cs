using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private MouseHover mouseHover;
    int currentQuestion = 0;
    public List<QuestionAndAnswer> QnA;

    void Start()
    {
        foreach (var question in QnA)
        {
            question.gameObject.SetActive(false);
        }
        QnA[currentQuestion].gameObject.SetActive(true);
    }

    public void CheckAnswer(string answer)
    {
        if (QnA[currentQuestion].Answer == answer)
        {
            mouseHover.IsQuizActive = false;
            NextQuestion();
        }

        if (currentQuestion == QnA.Count - 1)
        {
            QnA[currentQuestion].gameObject.SetActive(false);
            gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            mouseHover.IsQuizActive = false;
        }
    }

    public void NextQuestion()
    {
        if (currentQuestion < QnA.Count - 1)
            StartCoroutine(ShowNextQuestionCoroutine());
    }

    private IEnumerator ShowNextQuestionCoroutine()
    {
        yield return new WaitForSeconds(1f);
        QnA[currentQuestion].gameObject.SetActive(false);
        currentQuestion++;
        QnA[currentQuestion].gameObject.SetActive(true);
    }
}
