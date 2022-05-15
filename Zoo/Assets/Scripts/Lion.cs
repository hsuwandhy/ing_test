using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Lion : Animal
    {
        override public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, i);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
