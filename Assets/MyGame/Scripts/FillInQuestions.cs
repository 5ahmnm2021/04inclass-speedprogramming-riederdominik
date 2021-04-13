using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInQuestions : MonoBehaviour
{
    public int questionsRight;

    public Text questionsTextBox;

    public void QuestionsAdd()
    {
        questionsRight++;
    }

    void Update()
    {
        string questionsText = questionsRight.ToString();
        questionsTextBox.text = questionsText;
    }
}
