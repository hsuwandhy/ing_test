using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo:MonoBehaviour
    {
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
                SayHello();
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                EatLeaves();
            }
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
    }
    
}
