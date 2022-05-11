using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Zoo
{
    //Parent class that regulates all the behaviour for the child objects
    public class Animal : MonoBehaviour
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        public Text text;
        [SerializeField]
        private bool carnivourous, herbivourus;

        [SerializeField] public string greeting, eatingSounds;

        virtual public void Start()
        {
            EventManager.SayHello += SayHello;
            EventManager.DoTrick += DoTrick;

            if (carnivourous)
                EventManager.EatMeat += EatMeat;
            if(herbivourus)
                EventManager.EatLeaves += EatLeaves;
        }
        virtual public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = greeting;
        }

        virtual public string Greeting
        {
            get { return greeting; }
            set { greeting = value; }
        }

        virtual public string EatingSounds
        {
            get { return eatingSounds; }
            set { greeting = value; }
        }

        virtual public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }

        virtual public void DoTrick()
        {

        }


        virtual public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }

        virtual public void OnDisable()
        {
            EventManager.DoTrick -= DoTrick;
            EventManager.EatMeat -= EatMeat;
            EventManager.EatLeaves -= EatLeaves;
            EventManager.SayHello -= SayHello;
        }
    }
}

