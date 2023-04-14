using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    private String name = "";                               // 이름
    private String age  = "";                               // 나이
    private String job  = "";                               // 직업
    private String fvrtGame = "";                           // 선호게임
    private String visitTime = "";                          // 출몰시간
    private int    money     = 0;                           // 소지금
    private int    liking    = 0;                           // 호감도
    private List<String> think = new List<String>();        // 생각
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public String name {
        get { return name; }
        set { name = value; }
    }

    public String age {
        get { return age; }
        set { age = value;}
    }

    public String fvrtGame{
        get { return fvrtGame; }
        set {  fvrtGame = value;}
    } 

    public String visitTime{
        get{ return visitTime; }
        set {  visitTime = value;}
    }

    public int money{
        get{ return money; }
        set {  money = value;}
    }
    public int liking{
        get{ return liking; }
        set {  liking = value;}
    }

    public List<String> thinking{
        get { return thinking;}
        set { thinking = value;}
    }

}
