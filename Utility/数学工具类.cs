using UnityEngine;

namespace LazyToolkit
{
  public class 数学工具类
  {
    /// <summary>
    /// Returns a random integer number between min [inclusive] and max [inclusive] (Read Only).
    /// </summary>
    /// <param name="最小值"></param>
    /// <param name="最大值"></param>
    /// <returns></returns>
    public static int 获取随机整数(int 最小值, int 最大值)
    {
      return Random.Range(最小值, 最大值 + 1);
    }

    public static float 获取随机浮点数(float 最小值, float 最大值)
    {
      return Random.Range(最小值, 最大值);
    }

    public static Vector3 极坐标位移(Vector3 原点, float 半径, float 距离)
    {
      float x = Mathf.Sin(半径) * 距离;
      float y = Mathf.Cos(半径) * 距离;
      原点.x += x;
      原点.y += y;
      return 原点;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="成功率">0.00 ~ 1.00</param>
    /// <returns></returns>
    public static bool 判断成功率(float 成功率)
    {
      float tick = 获取随机浮点数(0, 1);
      bool result = tick < 成功率;
      return result;
    }
  }
}
