using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ol2 : MonoBehaviour {

    SpriteRenderer rend;
    void Start()
    {

        rend = gameObject.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        rend.enabled = false;
        if (ml.messageCount == 1)
        {
            rend.enabled = true;
        }
    }
}
