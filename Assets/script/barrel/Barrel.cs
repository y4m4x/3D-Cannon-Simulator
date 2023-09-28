using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public delegate void ScoreEvent();
    public static ScoreEvent scoreEvent;

    public void OnJointBreak()
    {
        scoreEvent?.Invoke();
    }
}
