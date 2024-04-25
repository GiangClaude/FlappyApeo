using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    //instantite: Ham ho tro khoi tao trong unity
    public GameObject pipeFrefab;

    private float countdown;
    public float timeDuration;
    public bool enableGenratePipe;

    private void Awake()
    {
        countdown = timeDuration;
        enableGenratePipe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enableGenratePipe == true)
        {
            countdown -= Time.deltaTime; //moi frame countdown -= 1/fps
                                         //Vi du: fps = 30=> moi frame count giam 1/30 => 1s(30 frame) count giam 1
            if (countdown <= 0)
            {
                //sinh ra ong
                Instantiate(pipeFrefab, new Vector3(6, Random.Range(-1.2f, 2.1f), 0), Quaternion.identity);
                countdown = timeDuration;
            }
        }
       
    }
   
}
