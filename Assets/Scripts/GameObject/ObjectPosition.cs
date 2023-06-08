using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    public float objectSpeed = 2.0f;

    public Vector3 objectStartPosition;
    public Vector3 objectPositionStart;

    public Transform currentObjectPosition;
    public GameObject sceneObject;

    // Start is called before the first frame update
    void Start()
    {
        objectStartPosition = sceneObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        sceneObject.transform.position=Vector3.MoveTowards(sceneObject.transform.position,objectStartPosition,Time.deltaTime*objectSpeed);

        if (sceneObject.transform.position == objectStartPosition)
        {
            objectStartPosition = objectPositionStart;
            if (objectStartPosition == objectPositionStart)
            {
                objectPositionStart = sceneObject.transform.position;
            }
        }
    }
}
