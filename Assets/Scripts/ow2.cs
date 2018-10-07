using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ow2 : MonoBehaviour {

    SpriteRenderer rend;
    void Start()
    {

        rend = gameObject.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        rend.enabled = false;
        if (mw.messageCount == 1)
        {
            rend.enabled = true;
        }
    }
}
