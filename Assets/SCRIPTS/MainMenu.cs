using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //StartGame() method makes it so when the player hits the Start button they automatically go into the first level.
    public void StartGame()
    {
        SceneManager.LoadScene(0);
        SceneManager.LoadSceneAsync("DARKNESS INSUES");
    }
    //OpeningOptions() method literally allows the player to open the Options menu.
    public void OpeningOptions()
    {
        SceneManager.LoadSceneAsync("Options");
    }
    //BackOutOfGame() method allows the player to go back if they need to.
    public void BackOutOfGame()
    {
        SceneManager.LoadSceneAsync("Main Menu");
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
    //This opens the EndCredits scene and allows the player to see all who have contributed to this project.
    public void OpeningEndCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
    }
}
//https://www.youtube.com/watch?v=DX7HyN7oJjE This is my resource that I used.
