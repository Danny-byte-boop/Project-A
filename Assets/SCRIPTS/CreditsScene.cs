using UnityEngine;

public class CreditsScene : MonoBehaviour
{
    public float scrollSpeed = 40f;
    private RectTransform rectTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Calls the RectTransform function within Unity
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    //Adds the scrolling effect within Unity for the Credit Scene
    void Update()
    {
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);
    }
}
//https://www.youtube.com/watch?v=Eeee4TU69x4 
//This youtuber helped me out a ton with rolling credits in Unity and they could help you too!
