using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerQuestion : MonoBehaviour
{
    public QuizManager quizManager;
    public string answerQuestion;

    private Button button;

    private void Awake() {
        button = GetComponent<Button>();
        button.onClick.AddListener(Answer);
    }

    public void Answer()
    {
        quizManager.CheckAnswer(answerQuestion);
    }
}
