using System;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

namespace LazyToolkit
{
  public class RandomActionInfo
  {
    public float weight;
    public Action action;

    public RandomActionInfo(float weight, Action action)
    {
      this.weight = weight;
      this.action = action;
    }
  }

  public class RandomTextInfo
  {
    public float weight;
    public string text;

    public RandomTextInfo(float weight, string text)
    {
      this.weight = weight;
      this.text = text;
    }
  }

  public static class ActionUtility
  {
    /// <summary>
    /// Execute random action by weight.
    /// </summary>
    /// <param name="actionInfos"></param>
    public static void CallRandomAction(List<RandomActionInfo> actionInfos)
    {
      var totalWeight = actionInfos.Sum(info => info.weight);
      var randomValue = Random.Range(0f, totalWeight);
      var tick = 0f;
      foreach (var actionInfo in actionInfos)
      {
        tick += actionInfo.weight;
        if (randomValue <= tick)
        {
          actionInfo.action();
          return;
        }
      }
    }
  }
}
