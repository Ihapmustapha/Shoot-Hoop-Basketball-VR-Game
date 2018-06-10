using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryTrigger: MonoBehaviour {
     

     void OnTriggerEnter(Collider Collider)
      {
        SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger>();
        trigger.ExcpectCollider(Collider); 
        
      }
}
