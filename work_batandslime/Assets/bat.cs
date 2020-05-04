using UnityEngine;
using UnityEngine.UI;
using System;

public class bat : MonoBehaviour
{
    [Header("蝙蝠的血量")]
    public int 血量 = 300;
    [Header("蝙蝠的攻擊力")]
    public int 攻擊力 = 30;
    [Header("蝙蝠的治癒量")]
    public int 治癒量 = 10;

    public Text result;
    public slime 史萊姆;

    public void Attack()
    {
        result.text = 史萊姆.name + "受到傷害 : " + 攻擊力 + "\n";
        史萊姆.Hurt();
    }

    public void Hurt()
    {
    int 總血量 = 血量 -= 史萊姆.攻擊力;
    result.text += "\n" + gameObject.name + "血量剩下" + 總血量;
    }

    public void Cure()
    {
    result.text = gameObject.name + "收到治癒 : " + 治癒量 + "\n"
                  + gameObject.name + "目前血量" + (血量 += 治癒量);
    }
}



