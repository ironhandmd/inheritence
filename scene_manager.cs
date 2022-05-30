using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public void LoadNextScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadTitleScene()
    {

        SceneManager.LoadScene("title");

    }


    public void GameOverScene()
    {
        SceneManager.LoadScene("gameover");
    }

    public void QuitGame()                                        // loads quit
    {
        Application.Quit();
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("credits");



    }
    public void LoadEndingScene() 
    {
        SceneManager.LoadScene("ending1B1");
    
    }

    public void LoadElectrecute() 
    {
        SceneManager.LoadScene("electrecuted_end");
    }
    public void LoadEnding1() 
    {
        SceneManager.LoadScene("ending1");
    }

    public void LoadSnake() 
    {
        SceneManager.LoadScene("snakebite");
    }

    public void LoadGiveCodex() 
    {

        SceneManager.LoadScene("givecodex");
    }

    public void LoadGameStart()
    {

        SceneManager.LoadScene("game");
    }
    public void LoadEnding3()
    {

        SceneManager.LoadScene("ending3");
    }


}
