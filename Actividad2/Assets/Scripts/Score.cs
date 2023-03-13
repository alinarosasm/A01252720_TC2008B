using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text tmpObj;
    public int score;
    int  vidas;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    public void AddPoints(int amount){
        score += amount;
        tmpObj.text = "Score: " + score;

    }
    public void Vidas(int amount){
        vidas -= amount;
    }

}
