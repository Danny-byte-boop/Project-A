using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Container;
    public GameObject timerText;
    //This method is when the player presses escape it pulls up the pause menu :)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Container.SetActive(true);
            timerText.SetActive(false);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    //ResumeButton() allows the player to resume the game if they want to 
    public void ResumeButton()
    {
        Container.SetActive(false);
        timerText.SetActive(true);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    //MainMenuButton() method allows the player to go back to the main menu :)
    public void MainMenuButton()
    {
        Time.timeScale = 1f;
        timerText.SetActive(true);
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Main Menu");
    }
    // QuitGame method closes the game.
    public void QuitGame()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
//https://www.youtube.com/watch?v=bt2NSujQ4yw&t=4s