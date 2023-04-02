using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FeedbackCube : MonoBehaviour
{
    public float timeEffect = 0.5f;
    public Tween tween;

    private void Start()
    {
        tween = transform.DOShakeScale(timeEffect).
            SetAutoKill(false).SetRecyclable(true).Pause(); 
    }

    public void FeedbackScale()
    {
        transform.localScale = new Vector3(1, 1, 1);
        tween.Restart();
    }

}
