using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARRaycastAimController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private GameObject target;

    [Header("Components")]
    [SerializeField] private Camera arCamera;
    [SerializeField] private ARRaycastManager raycastManager;
    [SerializeField] private ARPlaneManager planeManager;

    private ARPlane currentPlane;
    private List<ARRaycastHit> resultsOfHits;

    private void Awake()
    {
        currentPlane = null;
        resultsOfHits = new List<ARRaycastHit>();
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 centerOfScreen = arCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f, 0));
            raycastManager.Raycast(centerOfScreen, resultsOfHits, TrackableType.PlaneWithinBounds);

            try
            {
                ARRaycastHit? hit = resultsOfHits[0];
                currentPlane = planeManager.GetPlane(hit.Value.trackableId);

                target.transform.position = hit.Value.pose.position;
                target.transform.rotation = Quaternion.Euler(0, arCamera.transform.rotation.eulerAngles.y, 0);
            }
            catch (System.Exception) { }

            target.SetActive(currentPlane != null);
        }
    }
}