using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public string[] characterName;
    public GameObject[] objects;
    public float speed = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objects[Random.Range(0,6)], transform.position, transform.rotation);
        } 


    }
}
