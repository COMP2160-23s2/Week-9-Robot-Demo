using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimation : MonoBehaviour
{
    private Animator animator;
    private YesAndNo yesAndNo;

    void Start()
    {
        animator = GetComponent<Animator>();
        yesAndNo = GetComponent<YesAndNo>();

        yesAndNo.DoYes += YesAnimate;
        yesAndNo.DoNo += NoAnimate;
    }

    void YesAnimate()
    {
        animator.SetTrigger("Yes");
        int yesCount = yesAndNo.YesCount;
        animator.SetInteger("YesCount", yesCount);
    }

    void NoAnimate()
    {
        animator.SetTrigger("No");
    }
}
