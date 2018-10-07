using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro2 : MonoBehaviour {

    // Use this for initialization
    SpriteRenderer rend;
    void Start() {
   
       rend = gameObject.GetComponent<SpriteRenderer>();
    }
	// Update is called once per frame
	void Update () {
        rend.enabled = false;
        if (mc.messageCount == 1)
            {
            rend.enabled = true;
        }
    }
}
