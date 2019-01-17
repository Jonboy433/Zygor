/* Component for moving the character and NPCs alike */
using UnityEngine;

namespace Controllers.Movement
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField]
        protected float moveSpeed = 5.0f;

        public void Move(Vector3 movement)
        {

            transform.position += movement * Time.deltaTime * moveSpeed;
        }


    }
}
