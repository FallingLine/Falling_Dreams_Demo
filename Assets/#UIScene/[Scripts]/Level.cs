using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DancingLineFanmade.Level;

public class Level : MonoBehaviour
{
    public LevelData levelData;
    public TMP_Text levelName;
    public TMP_Text level;
    private string level_str;
    private int level_total;

    void Awake()
    {
        level_total = (int)levelData.level;
        level_str = "" + level_total;
        levelName.text = " " + levelData.levelTitle;
        level.text = level_str;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
