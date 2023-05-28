using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Feedback : MonoBehaviour
{
    public void FeedbackScale()
    {
        transform.DOScale(new
            Vector3(0.2f, -0.2f, 0), 0.1f).
            SetRelative().
            SetLoops(2,LoopType.Yoyo);
    }
}
