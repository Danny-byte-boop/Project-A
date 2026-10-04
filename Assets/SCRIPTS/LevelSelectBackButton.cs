using UnityEngine;

public class LevelSelectBackButton : MonoBehaviour
{
    //this method, LevelSelectBacktoMainMenu(), just makes it so that the player can go back to the Main Menu if they'd like to.
    public void LevelSelectBacktoMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
   
}
