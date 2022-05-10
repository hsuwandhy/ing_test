using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : MonoBehaviour
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;

        void Start()
        {
            EventManager.current.Eat += EatLeaves;
            EventManager.current.SayHello += SayHello;
        }
        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "splash";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }

        void OnDisable()
        {
            EventManager.current.Eat -= EatLeaves;
            EventManager.current.SayHello -= SayHello;
        }
    }

}
