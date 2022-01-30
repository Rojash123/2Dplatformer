using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40.0f;

    private float horizontalMove = 0.0f;
    private bool jump = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("speed",Mathf.Abs(horizontalMove));
        Debug.Log(horizontalMove);
        if(Input.GetButtonDown("Jump")){
            jump = true;
            StartCoroutine(AnimatorMakeJump());
        }
    }

    
    void FixedUpdate()
    {
        Debug.Log("call Fixed update");
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void OnLandPlayer(){
        
        animator.SetBool("jump",false);
    }

    private IEnumerator AnimatorMakeJump()
    {
        
        yield return new WaitForSeconds(0.04f);//because instantground check is not taken.
        animator.SetBool("jump",true);
    }
}
