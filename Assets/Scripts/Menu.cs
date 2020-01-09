using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void raceTrackOne()
    {
        SceneManager.LoadScene("scene2-night");
    }
    public void raceTrackOneSpaceship()
    {
        SceneManager.LoadScene("scene1-night");
    }
    public void back()
    {
        SceneManager.LoadScene("menu");
    }
    public void endGame()
    {
        Application.Quit();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

