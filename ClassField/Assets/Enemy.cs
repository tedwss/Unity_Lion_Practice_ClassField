using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Header("血量"), Tooltip("怪物的血量")]
    [Range(50, 500)]
    public int 血量;
    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Header("魔力"), Tooltip("怪物的魔力")]
    [Range(10, 100)]
    public int 魔力 = 100;
    /// <summary>
    ///怪物的移動速度 
    /// </summary>
    [Header("能力值")]
    [Range(1.0f, 50.5f)]
    public float 移動速度 = 10.5f;
    /// <summary>
    /// 攻擊力
    /// </summary>
    [Range(20, 200)]
    public int 攻擊力 = 50;
    /// <summary>
    /// 防禦力 
    /// </summary>
    [Range(0, 100)]
    public int 防禦力;
    /// <summary>
    /// 武器名稱
    /// </summary>
    [Header("裝備")]
    public string 武器名稱;
    /// <summary>
    /// 裝備名稱
    /// </summary>
    public string 裝備名稱 = "皮衣";
    /// <summary>
    /// 是否有帶鑰匙
    /// </summary>
    [Header("其他資料"), Tooltip("怪物是否有帶鑰匙")]
    public bool 是否帶有鑰匙 = false;
    /// <summary>
    /// 是否掉落寶物
    /// </summary>
    [Tooltip("怪物是否帶有寶物")]
    public bool 是否掉落寶物 = false;

}
