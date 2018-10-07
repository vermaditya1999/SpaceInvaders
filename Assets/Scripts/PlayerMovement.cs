using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    private int num_prizes = 5;
    public int score = 0;
    // Velocity vector
    private Vector2 velocity = new Vector2(4, 4);

    // Animator Component  
    Animator animator;

    // Health
    public static float health;

    // To Destroy
    public GameObject toDestroy;

    // Bar Object
    public GameObject bar;

    // Score Text
    public Text scoreText;

    void Start () {
        animator = GetComponent<Animator>();
        health = bar.transform.localScale.x;
	}
	
	void Update () {

        Vector3 pos = transform.position;

        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);

        float horDom = Mathf.Abs(Input.GetAxis("Horizontal"));
        float verDom = Mathf.Abs(Input.GetAxis("Vertical"));

        animator.SetBool("left", false);
        animator.SetBool("right", false);
        animator.SetBool("up", false);
        animator.SetBool("down", false);

        if (!(horDom == 0 && verDom == 0)) {
            GetComponent<AudioSource>().UnPause();
            if (horDom > verDom) {
                if (left) {
                    pos.x -= velocity.x * Time.deltaTime;
                    animator.SetBool("left", true);
                } else if (right) {
                    pos.x += velocity.x * Time.deltaTime;
                    animator.SetBool("right", true);
                }
            } else {
                if (down) {
                    pos.y -= velocity.y * Time.deltaTime;
                    animator.SetBool("down", true);
                } else if (up) {
                    pos.y += velocity.y * Time.deltaTime;
                    animator.SetBool("up", true);
                }
            }
        } else {
            GetComponent<AudioSource>().Pause();
        }

        transform.localPosition = pos;

        if (score == num_prizes) {
            SceneManager.LoadScene("Level2");
        }
        
        scoreText.text = score.ToString() + "/5";
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy" && this.tag == "Player") {
            if (health > 0) {
                health -= 0.01f;
            } else {
                if (gameObject != null) {
                    Destroy(gameObject);
                    Destroy(toDestroy);
                    SceneManager.LoadScene("loseScreen");
                }
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && this.tag == "Player")
        {
            if (health > 0)
            {
                health -= 0.01f;
            }
            else
            {
                if (gameObject != null)
                {
                    Destroy(gameObject);
                    Destroy(toDestroy);
                    SceneManager.LoadScene("loseScreen");
                }
            }
        }
    }
}
