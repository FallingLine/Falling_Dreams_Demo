using UnityEngine;
using DG.Tweening;

public class Shining : MonoBehaviour
{
    public CanvasGroup shiningObject;

    void Start()
    {
        Sequence sq = DOTween.Sequence();
        //��һ��������ʾ͸����  ��Χ��[0,1] ,����һ�������Ǿ���ʱ��,�������е���һ������ֵ
        sq.Append(shiningObject.DOFade(0.2f, 1.5f));
        sq.Append(shiningObject.DOFade(0.9f, 1));
        sq.SetLoops(-1);
    }
}

