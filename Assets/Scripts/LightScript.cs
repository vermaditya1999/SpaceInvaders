using UnityEngine;

public class LightScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.tag == "Enemy") {
            EnemyScript temp = collision.GetComponent<EnemyScript>();
            temp.flag = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
            if (collision.transform.gameObject.tag == "Enemy") {
                EnemyScript temp = collision.GetComponent<EnemyScript>();
                temp.flag = false;
            }
    }
}
