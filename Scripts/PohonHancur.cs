using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohonHancur : MonoBehaviour
{
    public GameObject asap;
    private Transform myTransform;
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
            Instantiate(asap, myTransform.position, Quaternion.identity);
            Destroy(asap, 1.5f);
            Destroy(this.gameObject, 0.2f);

        }
    }
}
