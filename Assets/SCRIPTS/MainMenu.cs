using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(0);
        SceneManager.LoadSceneAsync("DARKNESS INSUES");
    }
    public void OpeningOptions()
    {
        SceneManager.LoadSceneAsync("Options");
    }
    public void BackOutOfGame()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
//https://www.youtube.com/watch?v=DX7HyN7oJjE This is my source, StartGame() method makes it so when the player hits the Start button they automatically go into the first level.
//QuitGame() function completely closes the game when clicked