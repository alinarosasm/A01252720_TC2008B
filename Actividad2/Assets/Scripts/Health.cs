using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public int health;
    public int numHearts;

    public Image[] hearts;
    public Sprite Heart;
    public Sprite EmpHeart;
    public GameObject youWinText;
    public GameObject GameOverText;

    void Start()
    {
        youWinText.SetActive(false);
        GameOverText.SetActive(false);
    }

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++){
            if(i < health){
                hearts[i].sprite = Heart;
            } else{
                hearts[i].sprite = EmpHeart;
            }
            if(i < numHearts){
                hearts[i].enabled = true;
            }else{
                hearts[i].enabled = false;
            }

            if(health==0){
                GameOverText.SetActive(true);
            }
        }     

    }
            void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.tag == "enemy")
            {
                health = health - 1;
            }
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {

        if (collider.gameObject.tag == "checkpoint")
        {
            youWinText.SetActive(true);
        }
        }


}
