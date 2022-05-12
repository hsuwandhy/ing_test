using System.Collections;
using UnityEngine;

namespace Zoo
{
    public class Elephant : Animal
    {
        public override void DoTrick()
        {
            base.DoTrick();
            StartCoroutine(PerformTrick());
        }

        IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(0, i, 0);
                yield return new WaitForEndOfFrame();

            }
        }
    }
}