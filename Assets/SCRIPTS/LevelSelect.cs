using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    //Inside the LevelSelect1() method you can select "DARKNESS INSUES" immediately transporting you to the start of the game.
    public void LevelSelect1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("DARKNESS INSUES");
    }
}
