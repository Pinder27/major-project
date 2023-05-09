using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabing : MonoBehaviour
{

    [SerializeField] GameObject[] allobject;
    private Rigidbody rb;
   
    private void Update()
    {
       for (int i = 0; i <allobject.Length; i++)
       {
         rb = allobject[i].GetComponent<Rigidbody>();
       }
    }

    public void OnGrab()
    { for(int i=0;i<allobject.Length;i++){
           rb.isKinematic = true;
           Debug.Log(allobject[i].name);
       }
       
    }

    public void OnRelease()
    {
        for(int i=0;i<allobject.Length;i++){
           rb.isKinematic = true;
           Debug.Log(allobject[i].name);
       }
    }

}
