using UnityEngine;

public class DemoNotice : MonoBehaviour
{
    private GameObject demo;
    void Start()
    {
        demo = transform.Find("Demo").gameObject;
        GameObject.DontDestroyOnLoad(this.gameObject);
        GameObject.DontDestroyOnLoad(this.demo);
    }
}
