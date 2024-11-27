using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_1 : MonoBehaviour
{
    public PlayableDirector Timeline;
    private void OnTriggerEnter(Collider other)
    {
        Timeline.Play();
    }
}
