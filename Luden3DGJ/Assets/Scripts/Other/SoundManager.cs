using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Other
{
    public class SoundManager : MonoBehaviour
    {

        public AudioSource Click;
        public AudioClip ClickSound;

        public void OnClick()
        {
            Click.PlayOneShot(ClickSound);
        }
    }
}