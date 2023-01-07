using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNRANDOM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(
           Random.Range(0F, 1F),
           Random.Range(0F, 1F),
          0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
