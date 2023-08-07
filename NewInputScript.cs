using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.InputSystem.InputAction;

public class NewInputScript : MonoBehaviour
{
    public bool iCanJump;

    public Rigidbody _rigidBody;
    public PlayerControls controls;
    public InputAction Test;
    public GameObject smallBullet;
    public GameObject bigBullet;

    public float time;
    public float _moveSpeed;
    public float jumpForce = 2f;

    private bool IsStrongAttack;

    private void Awake()
    {
        controls = new PlayerControls();
        //Test.Enable();
    }


    private void OnEnable()
    {
        controls.ActionMap.Enable();
        controls.ActionMap.Jump.performed += OnJump;
        controls.ActionMap.Attack.canceled += OnFastAttack; // started, persformed, cnaceled 
        controls.ActionMap.Attack.performed += OnStrongAttack; // started, persformed, cnaceled 
        //controls.ActionMap.Attack.started += OnAttack; // started, persformed, cnaceled 
    }

    
    public void OnJump(CallbackContext context)
    {
        if (iCanJump != true) return;
        iCanJump = false;

        _rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void OnFastAttack(CallbackContext context)
    {
    
        if (time >= 0f) return;
        Instantiate(smallBullet, transform.position, transform.rotation);
        time = 1f;
        Debug.Log("OnFastAttack");
    }

    public void OnStrongAttack(CallbackContext context)
    {

        if (time >= 0f) return;
        var r = Instantiate(bigBullet, transform.position, transform.rotation);
        r.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        time = 1f;
        Debug.Log("OnStrongAttack");
    }

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        time -= Time.deltaTime;

        var value = controls.ActionMap.Movement.ReadValue<Vector2>();
        transform.position += new Vector3(value.x, 0, value.y) * Time.deltaTime * _moveSpeed;
    }

    private void OnDisable()
    {
        controls.ActionMap.Disable();
        controls.ActionMap.Jump.performed -= OnJump;
        controls.ActionMap.Attack.canceled -= OnFastAttack;
        controls.ActionMap.Attack.performed -= OnStrongAttack;
        //Test.Disable();
    }

    private void OnCollisionEnter(Collision collision)
    {
        iCanJump = true;
    }
}
