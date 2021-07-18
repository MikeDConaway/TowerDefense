using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    public Path path;
    public Transform curWaypoint;
    public Transform destination;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        curWaypoint = path.wayPoints[0];
        destination = path.wayPoints[1];
        transform.position = curWaypoint.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toDestination = destination.position - transform.position;
        toDestination = speed * Time.deltaTime * toDestination.normalized;
        transform.position += toDestination;
    }
}
