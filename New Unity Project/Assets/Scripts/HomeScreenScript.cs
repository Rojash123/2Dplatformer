using UnityEngine;  
using UnityEngine.SceneManagement;

public class HomeScreenScript : MonoBehaviour
{
    public GameObject pauseUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale = 0;
            pauseUI.SetActive(true);
        }
    }
    public void GoToGameScene() {  
        SceneManager.LoadScene("SurajTestScene");  
    }  
    public void GoToHomeScene() {  
        SceneManager.LoadScene("HomeScreen");  
    }
    public void PlayGame() {
        Time.timeScale = 1;
    }

    public void ExitGame() {  
        Debug.Log("exitgame");  
        Application.Quit();  
    }
} 