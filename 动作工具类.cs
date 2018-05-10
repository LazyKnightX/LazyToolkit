using System;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

namespace LazyToolkit
{
  public class 随机动作信息
  {
    public float 随机权重;
    public Action 随机动作;

    public 随机动作信息(float 随机权重, Action 随机动作)
    {
      this.随机权重 = 随机权重;
      this.随机动作 = 随机动作;
    }
  }

  public class 随机文本信息
  {
    public float 随机权重;
    public string 随机文本;

    public 随机文本信息(float 随机权重, string 随机文本)
    {
      this.随机权重 = 随机权重;
      this.随机文本 = 随机文本;
    }
  }

  public static class 动作工具类
  {
    /// <summary>
    /// Execute random action by weight.
    /// </summary>
    /// <param name="随机动作信息列表"></param>
    public static void 随机执行动作(List<随机动作信息> 随机动作信息列表)
    {
      var 总权重 = 随机动作信息列表.Sum(info => info.随机权重);
      var 随机值 = Random.Range(0f, 总权重);
      var 随机值检测点 = 0f;
      foreach (var 随机动作信息 in 随机动作信息列表)
      {
        随机值检测点 += 随机动作信息.随机权重;
        if (随机值 <= 随机值检测点)
        {
          随机动作信息.随机动作();
          return;
        }
      }
    }
  }

  public static class 文字工具类
  {
    /// <summary>
    /// Get random text by weight.
    /// </summary>
    /// <param name="infos"></param>
    public static string 随机获取文本(随机文本信息[] infos)
    {
      var totalWeight = infos.Sum(info => info.随机权重);
      var randomValue = Random.Range(0f, totalWeight);
      var tick = 0f;
      foreach (var info in infos)
      {
        tick += info.随机权重;
        if (randomValue <= tick)
        {
          return info.随机文本;
        }
      }
      return "";
    }
  }
}
