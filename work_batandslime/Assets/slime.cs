using UnityEngine;
using UnityEngine.UI;
using System;

public class slime : MonoBehaviour
{
    [Header("史萊姆的血量")]
    public int 血量 = 200;
    [Header("史萊姆的攻擊力")]
    public int 攻擊力 = 10;
    [Header("史萊姆的治癒量")]
    public int 治癒量 = 20;

    public Text result;
    public bat 蝙蝠;

    public void Attack()
    {
        蝙蝠.Hurt();
        result.text = 蝙蝠.name + "受到傷害 : " + 攻擊力 + "\n";
        result.text += "\n" + 蝙蝠.name + "血量剩下" + 蝙蝠.血量;
    }

    public void Hurt()
    {
        血量 -= 蝙蝠.攻擊力;
    }

    public void Cure()
{
    result.text = gameObject.name + "收到治癒 : " + 治癒量 + "\n"
                  + gameObject.name + "目前血量" + (血量 += 治癒量);
}
}
