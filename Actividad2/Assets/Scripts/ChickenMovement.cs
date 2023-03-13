using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    //[SerializeField] float limit = 10f;
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
            transform.Translate(0, (Time.deltaTime * speed), 0, Camera.main.transform);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
           // Debug.Log("Left Arrow");
           transform.Translate(-(Time.deltaTime * speed), 0, 0, Camera.main.transform);
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            //Debug.Log("Right Arrow");
           // transform.Translate(Vector3.right * Time.deltaTime);
           transform.Translate((Time.deltaTime * speed), 0, 0, Camera.main.transform);
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
           // Debug.Log("Down Arrow");
           transform.Translate(Vector3.down * Time.deltaTime);
           transform.Translate(0, -(Time.deltaTime * speed), 0, Camera.main.transform);
        }
    }
}
