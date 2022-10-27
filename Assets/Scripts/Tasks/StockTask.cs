using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockTask : Task
{
    [SerializeField]
    StockGamePanel gamePanel;
    protected override void OnStart()
    {

    }

    public override void OnInteract()
    {
        gamePanel.Show(); 
    }
}
