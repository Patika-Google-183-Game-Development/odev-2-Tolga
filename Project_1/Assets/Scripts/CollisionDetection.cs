using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;

    private void OnCollisionEnter(Collision other){
        _particleSystem.Play();
    }


}
