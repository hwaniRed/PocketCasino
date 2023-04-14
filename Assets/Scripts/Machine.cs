using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{   
    private String name = "";           // 이름
    private int    bet  = 0;            // 판돈
    private int    tod  = 0;            // Time on Device ( 기계에 들이는 시간)
    private float  winningRate = 0.0;   // 승률
    private int    buy  = 0;            // 구매가격
    private int    sell = 0;            // 판매가
    private int    level = 1;           // 머신 레벨
    private int    upgradeCost = 0;     // 업그레이드 비용
    private int    durability  = 0;     // 내구도

    public enum Type {
        SLOT = 0,
        PACHINKO,
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public String name{
        get { return name; }
        set { name = value; }
    } 
    
    public int bet{
        get { return bet; }
        set { bet = value; }
    }

    public int tod{
        get { return tod; }
        set { tod = value; }
    }

    public float winningRate{
        get { return winningRate; }
        set { winningRate = value; }
    }

    public int buy{
        get { return buy; }
        set { buy = value; }
    }

    public int sell{
        get { return sell; }
        set { sell = value; }
    }

    public int level{
        get { return level; }
        set { level = value; }
    }

    public int upgradeCost{
        get { return upgradeCost; }
        set { upgradeCost = value; }
    }

    public int durability{
        get { return durability; }
        set { durability = value; }
    }
}
