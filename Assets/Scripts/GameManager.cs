using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    public Text gameoverText;
    public Text maxTimeText;

    private float elapstedTime = 0.0f;
    private bool isGameover = false;

    void Update()
    {
        if(isGameover == false)
        {
            elapstedTime += Time.deltaTime;

            timeText.text = $"Time : {(int)elapstedTime} sec";
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        float currTime = elapstedTime;
        gameoverText.gameObject.SetActive(true);
        if(currTime > PlayerPrefs.GetFloat("MaxTime"))
        {
            PlayerPrefs.SetFloat("MaxTime", currTime);
        }
        maxTimeText.text = $"MaxTime : {(int)PlayerPrefs.GetFloat("MaxTime")} sec";
        isGameover = true;
    }
}
