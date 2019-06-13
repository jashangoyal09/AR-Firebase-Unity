using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vuforia : MonoBehaviour, ITrackableEventHandler
{
    TrackableBehaviour new_TrackableBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        new_TrackableBehaviour = GetComponent<TrackableBehaviour>();
        VuMarkManager new_Vumark;
        if(new_TrackableBehaviour!=null)
        {
            new_TrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        new_Vumark = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if(newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackerFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED && newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            OnTrackerLost();
        }
    }

    void OnTrackerFound()
    {
         
    }

    void OnTrackerLost()
    {

    }

}
