using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;
        [SerializeField]
        private bool carnivourous;

        public string greeting = "";
        public string eatingSounds = "";

        virtual public void Start()
        {
            EventManager.current.SayHello += SayHello;
            EventManager.current.DoTrick += DoTrick;

            if (carnivourous) 
                EventManager.current.EatMeat += EatMeat;
            else 
                EventManager.current.EatLeaves += EatLeaves;
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
            EventManager.current.DoTrick -= DoTrick;
            EventManager.current.EatMeat -= EatMeat;
            EventManager.current.EatLeaves -= EatLeaves;
            EventManager.current.SayHello -= SayHello;
        }
    }
}

