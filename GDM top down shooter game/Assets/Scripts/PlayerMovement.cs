using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float mSpeed;
    [SerializeField] private Rigidbody2D rigidbody2D;
    private Vector2 inputVector;

    private void Awake()
    {
        // Calling rigidbody from inspector to script. Rigidbody gsn variable zarlaj bga ch gsn ter n yag ali rigidbodyg script dr duudj ugch bgaga todorhoi bolgoh heregtei.
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Calling simple movement input to script. Horizontal, Vertical gdg 2 n project settings dotor yamr tovch gdgin onooj ugsun bga solihoor bol tend n solij bolnoo.
        inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        // Calling move func to update. 
        Move(inputVector);
    }

    void Move(Vector2 targetVelocity)
    {
        // Tsegtstei bailgahin tuld yamr ch uildl bsn ene shg tusd n func bolgood dra n updateruga duudd ywbal amar. 
        rigidbody2D.velocity = (targetVelocity * mSpeed) * Time.deltaTime;
    }
}
