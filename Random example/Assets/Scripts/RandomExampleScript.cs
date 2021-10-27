using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomExampleScript : MonoBehaviour
{
    public float number; 
    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(0f, 6f);
        transform.localScale = new Vector3(number, number, number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
