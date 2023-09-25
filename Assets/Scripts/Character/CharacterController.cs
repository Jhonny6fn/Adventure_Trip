using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject Disparo;
    private Rigidbody2D myrigi;
    private Animator myanimator;
    public float speed;
    bool colisionador;
    public float jump;

    private CheckGround GroundCheck;
    public static bool sonidoSalto;
    public static bool sonidoDisparo;
    private bool OnnOff;
    
    private AudioSource Music;

    public AudioClip FXsalto;
    public AudioClip FXdisparo;
    public static bool estoytocandosuelo;
    private bool estoyatacando, estoysaltando, tocosuelo, canMove;

    private void Awake()
    {
        Music = GetComponent<AudioSource>();
        sonidoSalto = false;
        sonidoDisparo = false;
    }
    void Start()
    {
        GroundCheck = FindObjectOfType<CheckGround>();
        myanimator = GetComponent<Animator>();
        myrigi = GetComponent<Rigidbody2D>();
        OnnOff = true;

        estoyatacando = false;
        estoysaltando = false;
        estoytocandosuelo = true;
        canMove = true;
    }

    void Update()
    {
        tocosuelo = estoytocandosuelo;
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        if (canMove)
        {
            if (Input.GetAxisRaw("Horizontal") == 0 && estoyatacando == false && estoysaltando == false)
            {
                myanimator.Play("Animacion_Idle");
            }
            
            if (Input.GetButtonDown("Fire1"))
            {
                if (transform.rotation.y == 0) Instantiate(Disparo, transform.position + new Vector3(0.5f, 2f, 0), transform.rotation);
                else Instantiate(Disparo, transform.position + new Vector3(-0.5f, 2f, 0), transform.rotation);
                myrigi.velocity = new Vector2(0, myrigi.velocity.y);
                myanimator.Play("Hidle");
                AudioSource.PlayClipAtPoint(FXdisparo, transform.position, 0.2f);
                sonidoDisparo = false;
            }

            if (Input.GetAxisRaw("Horizontal") > 0 && estoyatacando == false && estoysaltando == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed, Space.World);
                myanimator.Play("run");
                //myanimator.SetBool("RunVar", true);
            }

            if (Input.GetAxisRaw("Horizontal") < 0 && estoyatacando == false && estoysaltando == false)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed, Space.World);
                myanimator.Play("run");
                //myanimator.SetBool("RunVar", true);
            }
            colisionador = CheckGround.colPies;

            if (Input.GetButtonDown("Jump") && colisionador == true && myrigi.velocity.y == 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump);
                //myanimator.Play("salto_juego");
                //myanimator.SetTrigger("JumpTrigger");
                AudioSource.PlayClipAtPoint(FXsalto, transform.position, 0.2f);
                sonidoSalto = false;
            }
            if (Input.GetButtonDown("Jump") && colisionador == false)
            {
                Debug.Log("No toco el suelo");
            }
        }
        //if (myrigi.velocity.y < 0) myanimator.SetTrigger("Falling");
        //if (myrigi.velocity.y == 0) myanimator.SetTrigger("Landing");

    }
    /*
    public void InicioFuerzaSalto()
    {
        myanimator.ResetTrigger("JumpTrigger");
    }
    public void BloquearAtaque()
    {
        estoyatacando = true;
    }
    public void DesbloquearAtaque()
    {
        estoyatacando = false;
    }
    public void BloquearSalto()
    {
        estoysaltando = true;
        canMove = false;
    }
    public void DesbloquearSalto()
    {
        estoysaltando = false;
        canMove = true;
        myanimator.ResetTrigger("Falling");
        myanimator.ResetTrigger("Landing");
    }
    */
}
