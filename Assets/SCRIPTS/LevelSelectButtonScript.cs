using UnityEngine;

public class LevelSelectButtonScript : MonoBehaviour
{
    //The LevelSelectMenuButton() method makes it so the player can go into level select instead of pressing start to go to level 1.
    public void LevelSelectMenuButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level Select");
    }
}
