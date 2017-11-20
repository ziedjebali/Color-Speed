﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{

    public Animator animator;
    private Text plusOne;

    void Start()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);

        plusOne = animator.GetComponent<Text>();
    }

    public void SetText(string text)
    {
        plusOne.text = text;
    }

}
