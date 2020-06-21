using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RumahHancur : MonoBehaviour
{
    private Transform myTransform;
    public GameObject asap;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Peluru")
        {
            Destroy(this.gameObject, 5f);
            Instantiate(asap, myTransform.position, Quaternion.identity);
            Destroy(asap, 5.5f);
            
        }
    }
}
