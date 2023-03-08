using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    [SerializeField] int speed = 1f;
    [SerializeField] float limit;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            //Debug.Log("Up Arrow");
            transform.Translate(move.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            Debug.Log("Left Arrow");
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            Debug.Log("Right Arrow");
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            Debug.Log("Down Arrow");
        }
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        transform.Translate(move * speed * Time.deltaTime);
    }
}
