using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Interactible.InteractWithNPC
{
    public class NPCDialoge : CheckIfInteractible
    {
        [SerializeField] private GameObject textToShow;

        private void Start()
        {
            textToShow.SetActive(false);
        }
        protected override void ShowButton()
        {
            base.ShowButton();
            textToShow.SetActive(true);
        }
        protected override void HideButton()
        {
            base.HideButton();
            textToShow.SetActive(false);
        }
    }
}