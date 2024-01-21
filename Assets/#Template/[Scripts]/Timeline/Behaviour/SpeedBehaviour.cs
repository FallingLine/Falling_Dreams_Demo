using UnityEngine;
using UnityEngine.Playables;
using DancingLineFanmade.Level;

public class SpeedBehaviour : PlayableBehaviour
{
    public int speed_Behav;
    public bool setCameraFollowSpeed_Behav;
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        Player player_Behav = playerData as Player;
        Player.Instance.Speed = speed_Behav;
        if (setCameraFollowSpeed_Behav && CameraFollower.Instance) CameraFollower.Instance.followSpeed *= speed_Behav / 12f;
    }
}
