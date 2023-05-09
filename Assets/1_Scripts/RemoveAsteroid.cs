using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAsteroid : MonoBehaviour
{

private void OnCollisionEnter(Collision other) {
   if(other.gameObject.CompareTag("Asteroid")){
    Destroy(other.gameObject,0f);
    Debug.Log("Asteroid Removed");
   }
}
}
