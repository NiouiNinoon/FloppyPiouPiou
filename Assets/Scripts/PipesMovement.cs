using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    private float speed = 0.13f;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - speed, transform.position.y), 0.1f);
    }
}
