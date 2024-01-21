using Sirenix.OdinInspector;
using UnityEngine;

namespace DancingLineFanmade.Level
{
    public enum ActiveType
    {
        Display,
        Hide
    }

    public enum QualityLevel
    {
        Low,
        Medium,
        High
    }

    [DisallowMultipleComponent]
    public class ActiveByQuality : MonoBehaviour
    {
        [SerializeField, EnumToggleButtons, InfoBox("$message"), DisableInPlayMode] private ActiveType activeType = ActiveType.Hide;
        [SerializeField, EnumToggleButtons, DisableInPlayMode] private QualityLevel targetLevel = QualityLevel.Medium;

        private string message;

        internal void OnEnable()
        {
            int i;

            switch (targetLevel)
            {
                case QualityLevel.Low: i = 0; break;
                case QualityLevel.Medium: i = 1; break;
                case QualityLevel.High: i = 2; break;
                default: i = -1; break;
            }
            if (activeType == ActiveType.Display) if (QualitySettings.GetQualityLevel() > i) gameObject.SetActive(true); else gameObject.SetActive(false);
            if (activeType == ActiveType.Hide) if (QualitySettings.GetQualityLevel() < i) gameObject.SetActive(false); else gameObject.SetActive(true);
        }

        private void OnValidate()
        {
            string text1;
            string text2;
            string text3;

            if (activeType == ActiveType.Display)
            {
                text1 = "��ʾ";
                text2 = "����";
            }
            else
            {
                text1 = "����";
                text2 = "����";
            }
            switch (targetLevel)
            {
                case QualityLevel.Low: text3 = "�ͻ���"; break;
                case QualityLevel.Medium: text3 = "�л���"; break;
                case QualityLevel.High: text3 = "�߻���"; break;
                default: text3 = "-"; break;
            }

            message = "������" + text2 + text3 + "ʱ" + text1;
        }
    }
}