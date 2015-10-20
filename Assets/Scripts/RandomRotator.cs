using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{

    public float tumbleRate;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumbleRate;
    }
}
