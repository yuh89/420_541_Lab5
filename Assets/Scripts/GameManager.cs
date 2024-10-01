using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    private int score = 0;
    public int targetScore = 4;
    void Awake()
    {
        if  (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void IncrementScore()
    {
        score++;
        Debug.Log("Score: " +  score);

        if (score >= targetScore)
        {
            LoadNewScene();
        }
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene("VictoryScene");
    }
}
