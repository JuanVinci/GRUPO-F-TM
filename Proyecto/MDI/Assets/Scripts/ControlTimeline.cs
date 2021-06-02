using UnityEngine;
using UnityEngine.Playables;

public class ControlTimeline : MonoBehaviour
{
    private PlayableDirector timeline;

    private PlayableDirector Timeline 
    { 
        get
        {
            if (null == timeline)
                timeline = GetComponent<PlayableDirector>();

            return timeline;
        } 
    }

    public void Play()
    {
        Timeline.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }

    public void Pause()
    {
        Timeline.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }
}