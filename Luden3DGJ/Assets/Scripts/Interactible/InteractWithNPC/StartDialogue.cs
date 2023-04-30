using DialogueEditor;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Interactible.InteractWithNPC
{
    public class StartDialogue : MonoBehaviour
    {

        public NPCConversation Conversation;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                ConversationManager.Instance.StartConversation(Conversation);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            ConversationManager.Instance.EndConversation();
        }
    }
}