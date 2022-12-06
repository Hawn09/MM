using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ToGameScene2()
    {
        SceneManager.LoadScene("GameScene_2");
    }
    public void ToGameScene3()
    {
        SceneManager.LoadScene("GameScene_3");
    }
    public void ToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void ToLobbyScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }
    public void GameExp()
    {
        SceneManager.LoadScene("GameExp");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
