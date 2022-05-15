using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Pig : Animal
    {
        override public void EatLeaves()
        {
            base.EatLeaves();
            text.text = "munch munch oink";
        }

        override public void EatMeat()
        {
            base.EatMeat();
            text.text = "nomnomnom oink thx";
        }
    }
}
