using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 startingPosition;
    void Start()
    {
        startingPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        Transform siblingTransform = GetComponent<Transform>();

        float offset = Mathf.Sin(Time.time);
        siblingTransform.position = startingPosition + Vector3.right * offset;
    }
}
