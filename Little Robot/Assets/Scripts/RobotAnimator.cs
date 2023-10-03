using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimator : MonoBehaviour
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
        int yeses = yesAndNo.YesCount;
        animator.SetInteger("YesCount", yeses);
    }

    void NoAnimate()
    {
        animator.SetTrigger("No");
    }
}
