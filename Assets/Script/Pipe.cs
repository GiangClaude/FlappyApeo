using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //goi dua tren fps 
    {
        //Time.deltaTime = 1/fps = kiem soat toc do fps;
        Move();
    }

    private void Move()
    {
        //vector3: (x,y,z)
        
        this.transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
