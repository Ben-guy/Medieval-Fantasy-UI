using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonAnimation : MonoBehaviour
{

    public string wantedAnimation;

    public void selectButton(Animator wantedAnimator)
    {
        wantedAnimator.SetBool(wantedAnimation, true);
    }

    public void unselectButton(Animator wantedAnimator)
    {
        wantedAnimator.SetBool(wantedAnimation, false);
    }
}
