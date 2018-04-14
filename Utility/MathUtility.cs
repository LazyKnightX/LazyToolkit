using UnityEngine;

namespace LazyToolkit
{
  public class MathUtility
  {
    /// <summary>
    /// Returns a random integer number between min [inclusive] and max [inclusive] (Read Only).
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static int GetRandomInt(int min, int max)
    {
      return Random.Range(min, max + 1);
    }

    public static float GetRandomFloat(float min, float max)
    {
      return Random.Range(min, max);
    }

    public static Vector3 PolarCoordinateDisplacement(Vector3 origin, float radian, float distance)
    {
      float x = Mathf.Sin(radian) * distance;
      float y = Mathf.Cos(radian) * distance;
      origin.x += x;
      origin.y += y;
      return origin;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="successRate">0.00 ~ 1.00</param>
    /// <returns></returns>
    public static bool GetSuccessResult(float successRate)
    {
      float tick = GetRandomFloat(0, 1);
      bool result = tick < successRate;
      return result;
    }
  }
}
