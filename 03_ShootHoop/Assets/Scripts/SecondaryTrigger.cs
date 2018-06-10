using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {
    Collider expectedCollider;

    public void ExcpectCollider(Collider collider)
    {
        expectedCollider = collider; 
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            ScoreKeeper scorekeeper = FindObjectOfType<ScoreKeeper>();
            scorekeeper.IncrementScore(1);
        }
    }
}
