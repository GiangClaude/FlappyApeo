using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigibody;
    public float jumpForce;
    private bool levelStart;
    public GameObject GameController;
    private void Awake()
    {
        rigibody = this.gameObject.GetComponent<Rigidbody2D>();
        levelStart = false;
        rigibody.gravityScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //Ham update chay lien tuc
        //kiem tra co bam cach khong
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //GetKeyDown: an va giu phim => tiep tuc nhan
            //KeyDown: an phim 
            //KeyCode.Space: lay ma code cua space
            //Input: chua gia tri dau vao
            if (levelStart == false) 
            {
                levelStart = true;
                rigibody.gravityScale = 6;
                GameController.GetComponent<PipeGenerator>().enableGenratePipe = true;
                // Lay gia tri enable tu PipeGen thong qua Game Controller
            }
            BirdMoveUp();
        }
    }

    private void BirdMoveUp() //Lam chim bay
    {
        rigibody.velocity = Vector2.up * jumpForce;
        //velocity: gan gia tri vecto van toc cua vat the laf vecto (0,1) huong len
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
