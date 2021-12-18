using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float lifeTime;
    
    private void Awake() {
        Destroy(gameObject, lifeTime);
    }
}
