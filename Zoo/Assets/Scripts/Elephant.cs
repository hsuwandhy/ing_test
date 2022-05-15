using System.Collections;
using UnityEngine;

namespace Zoo
{
    public class Elephant : Animal
    {
        override public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(0, 0, i);
                yield return new WaitForEndOfFrame();

            }
        }
    }
}