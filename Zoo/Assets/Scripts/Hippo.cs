using System.Collections;
using UnityEngine;

namespace Zoo
{
    public class Hippo : Animal
    {
        override public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, i, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }

}
