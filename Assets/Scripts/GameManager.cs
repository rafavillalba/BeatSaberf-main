using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int health;
    public int score;
    public static GameManager manager;
    
    public void Start()
    {
        manager = this;
    }


    public void UpdateScore()
    {
        score++;
        transform.GetChild(1).GetComponent<Text>().text = score + " :Score";
    }

    public void TakeDamage()
    {
        health--;
        transform.GetChild(0).GetComponent<Text>().text = "Health: " + health;
    }
}
