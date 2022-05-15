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

        private Spawner spawner;

        virtual public void Start()
        {
            //Get the spawner component from the GameCanvas game object
            spawner = GameObject.Find("GameCanvas").GetComponent<Spawner>();


            EventManager.SayHello += SayHello;
            EventManager.DoTrick += DoTrick;

            if (carnivourous)
                EventManager.EatMeat += EatMeat;
            if (herbivourus)
                EventManager.EatLeaves += EatLeaves;
        }
        virtual public void SayHello()
        {
            if (spawner.input.text == name)
            {
                Balloon.SetActive(true);
                text.text = greeting;
            }

            if (spawner.input.text == "")
            {
                Balloon.SetActive(true);
                text.text = greeting;
            }
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
            StartCoroutine(PerformTrick());
        }

        virtual public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
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

