using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour

{
    [SerializeField] Score scoreObj;
    public int points;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreObj.AddPoints(-1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            scoreObj.AddPoints(1);
        }

    }

}
