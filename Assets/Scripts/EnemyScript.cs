using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float speed;
    public Transform player;
    private Rigidbody2D rb2d;
    public bool flag = false; 

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        if (flag && player != null) {   
            float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
            transform.eulerAngles = new Vector3(0, 0, z);
            rb2d.AddForce(gameObject.transform.up * speed);
        }
            
    }

}
