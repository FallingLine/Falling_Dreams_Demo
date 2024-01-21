using UnityEngine;
using UnityEngine.Playables;
using DancingLineFanmade.Level;
using UnityEngine.Timeline;

public class SpeedClip : PlayableAsset,ITimelineClipAsset
{
    public int speed = 12;
    public bool setCameraFollowSpeed = true ;

    public ClipCaps clipCaps => ClipCaps.None;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<SpeedBehaviour>.Create(graph);
        var SpeedBehaviour = playable.GetBehaviour();
        SpeedBehaviour.speed_Behav = speed;
        SpeedBehaviour.setCameraFollowSpeed_Behav = setCameraFollowSpeed;
        return playable;
    }
}