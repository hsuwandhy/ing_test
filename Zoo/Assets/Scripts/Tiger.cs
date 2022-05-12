using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Tiger : Animal
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
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
