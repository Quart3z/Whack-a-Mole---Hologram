using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
public class ScoreManager : MonoBehaviour
{
    public static int[] score1, score2;
    public UnityEngine.UI.Text[] scoreText1, scoreText2;
    [SerializeField]private GameObject[] winPanel;
    [SerializeField]private UnityEngine.UI.Text[] winText;
    [SerializeField] private int winScore;
    // Start is called before the first frame update

    void Awake()
    {
        score1 = new int[4];
        score2 = new int[4];
    }

    // Update is called once per frame
    void Update()
    {   
        for(int i=0; i<scoreText1.Length; i++)
        {

            scoreText1[i].text = "Score: " + score1[i].ToString();
            scoreText2[i].text = "Score: " + score2[i].ToString();

        }

        if(score1[0] == winScore)
        {

            Time.timeScale = 0;

            foreach (var p in winPanel)
            {
                p.gameObject.SetActive(true);
                Debug.Log("p1 win");
            }

            foreach (var t in winText)
            {
                t.text = "Player 1 win \n Press B to continue";
            }

            if (Input.GetKeyDown(KeyCode.B)) {
                Time.timeScale = 1;

                SceneManager.LoadScene(SceneManager.GetActiveScene().name); }

        }

        else if (score2[0] == winScore)
        {

            Time.timeScale = 0;

            foreach (var p in winPanel)
            {
                p.gameObject.SetActive(true);
                Debug.Log("p2 win");
            }

            foreach (var t in winText)
            {
                t.text = "Player 2 win \n Press B to continue";
            }

            if (Input.GetKeyDown(KeyCode.B)) {
                Time.timeScale = 1;

                SceneManager.LoadScene(SceneManager.GetActiveScene().name); }

        }

    }
    public static void scoreIncrement1(int amt)
    {
        for(int i=0; i<score1.Length; i++)
        {
           score1[i] += amt;
        }

    }
    public static void scoreIncrement2(int amt)
    {
        for (int i = 0; i < score2.Length; i++)
        {
            score2[i] += amt;
        }
    }
}
