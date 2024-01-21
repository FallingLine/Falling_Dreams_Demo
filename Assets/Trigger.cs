using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Animator getGem;
    public void TriggerOn()
    {
        getGem.SetTrigger("GetGem");
    }
}