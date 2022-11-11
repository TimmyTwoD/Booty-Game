using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*
     * Start button: Load to next scene
     * Options button: Open options screen / Close options screen
     * Quit: Exit game
     */

    public string firstLevel; // What the next scene will be


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel); // Load the next scene
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting"); // Debugging purposes
    }
}
