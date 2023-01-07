using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(
            Random.Range(-4F, 4F),
            Random.Range(-4F, 4F),
           0F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
