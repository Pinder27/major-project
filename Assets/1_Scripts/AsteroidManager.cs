using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Asteroid Size Manager")]
   [SerializeField] private Vector3 AsteroidManagersize;
   [Header("Spawning Time Manager")]
   float SpawningRate=2f,SpawningTime=0;
   [Header("Asteroid Sizes")]
   [SerializeField] private float _minSize=0.5f;
   [SerializeField] private float _MaxSize=2.5f;
   [SerializeField] private GameObject Asteroid;


    void Start()
    {
       

    }

private void OnDrawGizmos() {
    Gizmos.color = Color.red;
    Gizmos.DrawCube(transform.position,AsteroidManagersize);
}
    // Update is called once per frame
    void Update()
    {

        // Spawning the object after a certain time 
        SpawningTime+=Time.deltaTime;
        if(SpawningTime>SpawningRate){
            SpawningObject();
            SpawningTime=0;
        }
 
    }


// Spanning The Object 
     public void SpawningObject(){
        Debug.Log("Calling");
        SpawningTime+=Time.deltaTime;

        // Random Position for Spanning the Object 
        float XPosition = Random.Range(-AsteroidManagersize.x/2,AsteroidManagersize.x/2);
        float Yposition = Random.Range(-AsteroidManagersize.y/2,AsteroidManagersize.y/2);
        float Zposition = Random.Range(-AsteroidManagersize.z/2,AsteroidManagersize.z/2);
      
       //   Spanning Point of the object around the AsteroidSpanner 
        Vector3 SpawnPoint = transform.position+new Vector3(XPosition,Yposition,Zposition);
          
        // Spanning   Asteroid
        GameObject asteroid =  Instantiate(Asteroid,SpawnPoint,transform.rotation);

        // Changing the Size of Asteroid to Random
        asteroid.transform.localScale = new Vector3(Random.Range(_minSize,_MaxSize),Random.Range(_minSize,_MaxSize),Random.Range(_minSize,_MaxSize));
        
        // Setting the Parent of all instatiated element
        asteroid.transform.SetParent(this.transform);
  
    }
}
