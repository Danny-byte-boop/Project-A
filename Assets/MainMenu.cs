using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("DARKNESS INSUES");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
//https://www.youtube.com/watch?v=DX7HyN7oJjE This is my source, StartGame() method makes it so when the player hits the Start button they automatically go into the first level.
//QuitGame() function completely closes the game when clicked