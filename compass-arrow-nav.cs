using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] GameObject targetObject;

    void Update()
    {
        // Be sure to Arrow point align with X vector
        Vector3 target = targetObject.transform.position;
        target.z = 0f;

        Vector3 objectPosition = transform.position;
        target.x = target.x - objectPosition.x;
        target.y = target.y - objectPosition.y;

        float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


    }
}
