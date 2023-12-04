using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private MouseHover mouseHover;
    public List<QuestionAndAnswer> QnA;

    public void CheckAnswer(string answer)
    {
        QnA.ForEach(qna => {
            if (qna.Answer == answer)
            {
                mouseHover.IsQuizActive = false;
                gameObject.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                return;
            }
        });
    }

}
