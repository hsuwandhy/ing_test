using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Zebra : Animal
    {
        override public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(0, i, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
