using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableGame : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
