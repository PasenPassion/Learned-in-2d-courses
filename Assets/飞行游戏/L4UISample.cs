
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 一个简单的UI逻辑例子
/// </summary>
public class L4UISample : MonoBehaviour
{
    /// <summary>
    /// 引用的UI Text对象
    /// </summary>
    public Text Text1;
    /// <summary>
    /// 计数变量
    /// </summary>
    public int count = 0;
    void Start()
    {
        // 初始时设置默认数字
        Text1.text = count.ToString();
    }

    public void OnClickButton1()
    {
        // 增加一个数，并且刷新
        count += 1;
        Text1.text = count.ToString();
    }
    public void OnClickButton2(int i)
    {
        // 将传入的变量赋值
        Text1.text = i.ToString();
    }
}