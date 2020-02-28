using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    float hp = 100;


    void Start()
    {
        
    }

    void Update()
    {
        if(hp <= 0)
        {
            Destroy(gameObject);
        }

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if (gameObject.tag == "Player")
        {
            if (Input.GetMouseButtonDown(0))
            {
                hp -= 10;
            }
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Health: " + hp);
    }
}
