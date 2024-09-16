using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] float score = -1;

    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("You've bumped into a thing this many times: "+ score);
    }
}
