using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody2D rb;

    //float speed = 2.0f;

    //float boostTimer;
    //bool boosting;

    //Vector2 move;
    //bool jump = false;

    //GroundCheck
    //public LayerMask groundLayer;
    ////bool isGrounded;
    //public Transform groundCheck;

    Animator anim;

    //HealthBar
    public HealthBarController healthBar;
    public int currentHealth;


    //GameObjects - Hearts
    //public GameObject heart1;
    //public GameObject heart2;
    //public GameObject heart3;
    //public GameObject heart4;
    //public GameObject heart5;


    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();

        //boostTimer = 0;
        //boosting = false;

        currentHealth = GameData.maxHealth;
        healthBar.SetMaxHealth(GameData.maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
            Debug.Log("---");
        }
        ////var feet = new Vector2(transform.position.x, transform.position.y - 0.7f);
        ////var dimensions = new Vector2(-1.5f, 0.1f);
        ////var isGrounded = Physics2D.OverlapBox(feet, dimensions, 0, groundLayer);
        //var isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        //move = Vector2.zero;
        ////anim.SetBool("isGrounded", isGrounded);

        //if (Input.GetMouseButtonDown(1))
        //{
        //    Debug.Log("Attack!");
        //    var mousePos = Input.mousePosition;
        //    Debug.Log(mousePos);
        //}

        //if (boosting)
        //{
        //    boostTimer += Time.deltaTime;
        //    if (boostTimer >= 3)
        //    {
        //        speed = 2.0f;
        //        boostTimer = 0;
        //        boosting = false;
        //    }
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (isGrounded)
        //    {
        //        jump = true;

        //    }

        //}
        //if (Input.GetKeyDown(KeyCode.Space) && Input.GetMouseButton(0))
        //{
        //    if (isGrounded)
        //    {
        //        jump = true;
        //        rb.AddForce(Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
        //        EnergyDamage();
        //        if (EnergyBar.currentHealth <= 0)
        //        {
        //            rb.AddForce(Vector2.up * 8, ForceMode2D.Impulse);
        //        }
        //    }
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    //rb.velocity = new Vector2(-speed, 0);
        //    move.x = -1 * speed;
        //    anim.SetBool("PlayerWalking", true);
        //    anim.SetBool("Player2IsWalking", true);
        //}

        //else if (Input.GetKey(KeyCode.D))
        //{
        //    //rb.velocity = new Vector2(speed, 0);
        //    move.x = 1 * speed;
        //    anim.SetBool("PlayerWalking", true);
        //    anim.SetBool("Player2IsWalking", true);
        //}

        //else
        //{
        //    anim.SetBool("PlayerWalking", false);
        //    anim.SetBool("Player2IsWalking", false);
        //}

        //anim.SetBool("isGrounded", isGrounded);

    }

    void FixedUpdate()
    {
        //if (jump)
        //{
        //    jump = false;
        //    rb.AddForce(Vector2.up * 8, ForceMode2D.Impulse);

        //}

        ////isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        //rb.AddForce(move * 6);

        //var velocity = rb.velocity;
        //velocity.x = Mathf.Clamp(velocity.x, -5, 5);
        //rb.velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "SpeedBoost")
        //{
        //    boosting = true;
        //    speed = 5;
        //    Destroy(collision.gameObject);
        //}
        //if (collision.tag == "HideWall")
        //{
        //    Destroy(collision.gameObject);
        //}
        //if (collision.tag == "SafeZone")
        //{
        //    currentHealth += 20;
        //    EnergyBar.SetHealth(currentHealth);
        //    Destroy(collision.gameObject);

        //}
        //if (collision.tag == "TransS")
        //{
        //    UnityEngine.SceneManagement.SceneManager.LoadScene("NightScene");
        //}
        //if (collision.tag == "EndEnd")
        //{
        //    UnityEngine.SceneManagement.SceneManager.LoadScene("End");
        //}
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "DeadZone")
        {
            //HealthDamage();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //HealthDamage();
        }
    }

    void EnergyDamage()
    {
        currentHealth -= 5;
        healthBar.SetHealth(currentHealth);
    }

    //void HealthDamage()
    //{
    //    GameData.maxPlayerHealth -= 5;
    //    if (GameData.maxPlayerHealth >= 80 && GameData.maxPlayerHealth <= 100)
    //    {
    //        heart1.SetActive(true);
    //        heart2.SetActive(true);
    //        heart3.SetActive(true);
    //        heart4.SetActive(true);
    //        heart5.SetActive(true);
    //    }
    //    else if (GameData.maxPlayerHealth < 80 && GameData.maxPlayerHealth >= 60)
    //    {
    //        heart1.SetActive(true);
    //        heart2.SetActive(true);
    //        heart3.SetActive(true);
    //        heart4.SetActive(true);
    //        heart5.SetActive(false);
    //    }
    //    else if (GameData.maxPlayerHealth < 60 && GameData.maxPlayerHealth >= 40)
    //    {
    //        heart1.SetActive(true);
    //        heart2.SetActive(true);
    //        heart3.SetActive(true);
    //        heart4.SetActive(false);
    //        heart5.SetActive(false);
    //    }
    //    else if (GameData.maxPlayerHealth < 40 && GameData.maxPlayerHealth >= 20)
    //    {
    //        heart1.SetActive(true);
    //        heart2.SetActive(true);
    //        heart3.SetActive(false);
    //        heart4.SetActive(false);
    //        heart5.SetActive(false);
    //    }
    //    else if (GameData.maxPlayerHealth < 20 && GameData.maxPlayerHealth >= 0)
    //    {
    //        heart1.SetActive(true);
    //        heart2.SetActive(false);
    //        heart3.SetActive(false);
    //        heart4.SetActive(false);
    //        heart5.SetActive(false);
    //    }
    //    else if (GameData.maxPlayerHealth < 0)
    //    {
    //        heart1.SetActive(false);
    //        heart2.SetActive(false);
    //        heart3.SetActive(false);
    //        heart4.SetActive(false);
    //        heart5.SetActive(false);
    //        GameOver();
    //    }

    //}
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
}
