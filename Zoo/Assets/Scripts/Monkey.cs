using System.Collections;
using UnityEngine;

namespace Zoo
{

    public class Monkey : Animal
    {
        override public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, i, i);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}