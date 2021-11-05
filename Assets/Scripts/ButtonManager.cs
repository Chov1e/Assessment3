using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public string SceneName;

    public void ChangeToScene()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Restart()

    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Pacstudent");
    }

    public void Level2()
    {
    }

    public void exitgame()
    {
        SceneManager.LoadScene("StartScene");
    }
}