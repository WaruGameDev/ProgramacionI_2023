using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TouchTheCube : MonoBehaviour
{
    //public int exp = 1;
    public FeedbackCube feedbackCube;
    private void OnMouseDown()
    {
        GameManagerCubito.instance.
            AddExperience(GameManagerCubito.instance.expForClick);
        feedbackCube.FeedbackScale();
    }
}
