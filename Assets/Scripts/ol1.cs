using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ol1 : MonoBehaviour {

    SpriteRenderer rend;
    void Start()
    {

        rend = gameObject.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        rend.enabled = false;
        if (ml.messageCount == 0)
        {
            rend.enabled = true;
        }
    }
}
