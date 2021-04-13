using UnityEngine;

public class QuestionScript : MonoBehaviour
{
    public void AddToNumber()
    {
        GetComponent<FillInQuestions>().QuestionsAdd();

    }
}