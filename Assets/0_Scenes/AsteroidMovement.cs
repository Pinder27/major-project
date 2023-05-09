using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    
    [Header("Movement Speed")]
    [SerializeField] private float MinSpeed;
    [SerializeField] private float MaxSpeed;
    [Header("Rotational Motion")]
    [SerializeField] private float RotationSpeed=2f;
    [Header ("Movement Direction")]
    [SerializeField] private Vector3 MoveDirection;

    [SerializeField] private Vector3 RotationDirection;

    // Update is called once per frame
    void Update()
    {

    //   Vector3 NewPosition = transform.position+MoveDirection*Random.Range(MinSpeed,MaxSpeed)*Time.deltaTime;

    //   transform.position=NewPosition;

    transform.Translate(MoveDirection*Random.Range(MinSpeed,MaxSpeed)*Time.deltaTime,Space.World);
    transform.Rotate(RotationDirection*RotationSpeed*Time.deltaTime);
    
    }
}
