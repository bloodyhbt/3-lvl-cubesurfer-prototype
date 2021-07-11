using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    float height;
    float reduction = 1.5f;

    void Start()
    {
        mainCube = GameObject.Find("Player");
    }

    
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1.5f, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void HeightReduction()
    {
        height-=reduction;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Collect"&&other.gameObject.GetComponent<CollectableCube>().GetIsCollected()==false)
        {
            height += 1.5f;
            other.gameObject.GetComponent<CollectableCube>().MakeCollected();
            other.gameObject.GetComponent<CollectableCube>().SetIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
