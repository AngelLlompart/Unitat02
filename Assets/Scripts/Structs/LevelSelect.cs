using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public Difficulty selectedDifficulty;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene((int)selectedDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum Difficulty
    {
        Easy,
        Normal,
        Hard,
        Expert
    }
}
