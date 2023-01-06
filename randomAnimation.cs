using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomAnimation : StateMachineBehaviour
{

    public string IntParameterName;
    public int StateCount = 0;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger(IntParameterName, Random.Range(0, StateCount));

    }
}
