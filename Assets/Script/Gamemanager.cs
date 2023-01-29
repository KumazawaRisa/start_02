using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startbutton()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("CharacterTitle");
    }

    public void NextButton()
    {
        Debug.Log("Next");
        SceneManager.LoadScene("SelectCharacter");
    }

    public void BoyButton()
    {
        Debug.Log("Boy");
    }

    public void GirlButton()
    {
        Debug.Log("Girl");
    }
}
