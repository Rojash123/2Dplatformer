using UnityEngine;
using System.Collections;

public class Player2MovementScript : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40.0f;

    private float horizontalMove = 0.0f;
    private bool jump = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("HorizontalPlayer2") * runSpeed;

        animator.SetFloat("speed",Mathf.Abs(horizontalMove));
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            jump = true;
            StartCoroutine(AnimatorMakeJump());
        }
    }

    
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void OnLandPlayer(){
        animator.SetBool("jump",false);
    }

    private IEnumerator AnimatorMakeJump()
    {
        yield return new WaitForSeconds(0.04f);
        animator.SetBool("jump",true);
    }
}
