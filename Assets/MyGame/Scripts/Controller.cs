using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public void ChangeScene0to1()
    {
        SceneManager.LoadScene("01Scene2");
    }

    public void ChanceScene1to2()
    {
        SceneManager.LoadScene("02Scene3");
    }

    public void ChangeScene2to0()
    {
        SceneManager.LoadScene("00Scene1");
    }

}