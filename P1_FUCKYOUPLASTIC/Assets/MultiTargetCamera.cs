using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MultiTargetCamera : MonoBehaviour
{
    //malte, taget fra  https://www.youtube.com/watch?v=aLpixrPvlB8
    public List<Transform> targets; //da kameraet skal f�lge to spillere laves en list

    public Vector3 offset; //s� vi kan bestemme hvor kameraet skal v�re
    public float smoothTime = .5f;
    private Vector3 velocity;
    private Camera cam;

    public float minZoom = 80f;
    public float maxZoom = 40f;
    public float zoomLimiter = 50f;


    Vector3 startPos = new Vector3(0,12,-13);
    public bool isDead = false;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void LateUpdate() //lateupdate s� den kalder efter bev�gelsen
    {
        if (targets.Count == 0)
            return;

        Movement();
        Zoom();

    }
    private void FixedUpdate()
    {
        if (isDead)
        {
            transform.position = Vector3.Lerp(transform.position, startPos, 1 * Time.deltaTime);
        }
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimiter);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);


    }


    void Movement()
    {
        Vector3 centerPoint = GetCenterPoint(); //koordinat for centerpoint mellem targets

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime); //smoothdamp er en unity funktion der g�r kamerabev�gelsen mere smooth

    }


    float GetGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero); //bounds er en unity class der indkapsler objects
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position); //laver bounds boxen ny st�rrelse til at indeholde et nyt target
        }

        return bounds.size.x;
    }






    Vector3 GetCenterPoint() //method for at finde centerpoint mellem targets
    {
        if (targets.Count == 1) //hvis kun et target, s� skal kameraet bare v�re ved den spiller
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero); //bounds er en unity class der indkapsler objects
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position); //laver bounds boxen ny st�rrelse til at indeholde et nyt target
        }
       
        return bounds.center;
    }


}
