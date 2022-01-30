using UnityEngine;  
using UnityEngine.SceneManagement;

public class HomeScreenScript : MonoBehaviour
{
    
    void Update()
    {
        
    }

    public void GoToGameScene() {  
        SceneManager.LoadScene("SurajTestScene");  
    }  

    public void ExitGame() {  
        Debug.Log("exitgame");  
        Application.Quit();  
    } 
    // public void Scene2() {  
    //     SceneManager.LoadScene("Scene2");  
    // }  
    // public void Scene3() {  
    //     SceneManager.LoadScene("Scene3");  
    // }
} 