using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackQuickBehaviour : StateMachineBehaviour
{
    public AudioClip audioClip;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PlayerController playerController = animator.GetComponent<PlayerController>();
        if (playerController != null)
        {
            playerController.SetAtacking(true, UpDown.Up);

            // Check if the attackAudioClip is assigned in the Unity Editor
            if (audioClip != null)
            {
                // Create an AudioSource component if not already present
                AudioSource audioSource = playerController.GetComponent<AudioSource>();
                if (audioSource == null)
                {
                    audioSource = playerController.gameObject.AddComponent<AudioSource>();
                }

                // Play the assigned audio clip
                audioSource.clip = audioClip;
                audioSource.Play();
            }

        }
    
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<PlayerController>().SetAtacking(false, UpDown.Up);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
