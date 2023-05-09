using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class GunHandler : MonoBehaviour
{
  [SerializeField] private AudioClip laserAudioClip;
  [SerializeField] private Animator laserAnimation;


private AudioSource LaserAudioSource;

private void Awake() {
    LaserAudioSource = GetComponent<AudioSource>();
}
   public void LaserGunFired(){
// animate the gun 
laserAnimation.SetTrigger("Fire");

// play laser SFX
LaserAudioSource.PlayOneShot(laserAudioClip);
// Raycast

   }
}
