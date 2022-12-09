using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float forwardInput;
    [SerializeField] public float speed;
    [SerializeField] public float turnSpeed;

    public Vector3 force;

    private Animator _playerAnim;

    private Rigidbody _playerRb;
    public float force;
    public float forceDown;
    public float gravityModifier = 1f;

    public bool isOnGround;
    public bool isJumping;
    public bool isFalling;
    public bool isLanding;

    public bool jumpCancelled;
    public float jumpTimer;
    public float jumpButtonPressedTime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        //Variable wird gefuellt mit Komponente, Referenz wird gesetzt
        _playerAnim = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Wert definieren fuer Bewegung
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);

        _playerAnim.SetFloat("Run", forwardInput);

        if(forwardInput != 0 || horizontalInput != 0)
        {
            _playerAnim.SetBool("Walk", true);
        }
        else
        {
            _playerAnim.SetBool("Walk", false);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isFalling)
        {

            isOnGround = false;
            isJumping = true;

            //_playerRb.AddForce(force, ForceMode.Impulse);
            if(isJumping)
            {
                _playerAnim.SetTrigger("Jump");
            }

        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
            isFalling = true;

            if(isFalling)
            {
                _playerAnim.SetBool("Fall", true);
            }
        }

        if(isJumping)
        {
            jumpTimer += Time.deltaTimer;
            if(Input.GetKeyUp(KeyCode.Space))
            {
                jumpCancelled = true;
            }
            if(jumpTimer > jumpButtonPressedTime)
            {
                isJumping = false;
                jumpCancelled = true;
            }
        }

        if(_playerRb.velocity.y < 0 && isFalling)
        {
            isFalling = false;
            isLanding = true;
            _playerAnim.SetBool("Fall",false);
        }
    }

    void FixedUpdate()
    {
        if(isJumping && !jumpCancelled)
        {
            gravityModifier = 1f;
            _playerRb.AddForce(Vector3.up * force, ForceMode.Force);
        }

        if(isFalling || isOnGround || isLanding || jumpCancelled)
        {
           // _playerRb.AddForce(Vector3.down * forceDown * _playerRb.mass);
           gravityModifier = 25f;
        }

        _playerRb.AddForce(Physics.gravity * (gravityModifier - 1) * _playerRb.mass);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            //isLanding = false;

            if(isFalling)
            {
                _playerAnim.SetBool("Fall", false);
                isFalling = false;
            }
        }
    }

}
