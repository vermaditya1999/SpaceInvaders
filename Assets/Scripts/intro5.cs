using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro5 : MonoBehaviour {

    SpriteRenderer rend;
    void Start() {

        rend = gameObject.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update() {
        rend.enabled = false;
        if (mc.messageCount == 4) {
            rend.enabled = true;
        }
    }
}
