using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Shoot2
public class Shoot2 : MonoBehaviour
{
    public class Shoot : MonoBehaviour
    {
        [SerializeField] private PlayerInputController _inputController;
        [SerializeField] private GameObject bullet;
        private void Update()
        {
            if (_inputController != null && _inputController.ShootInput) PullTrigger();
        }
        public void PullTrigger() => Instantiate(bullet, this.transform.position, Quaternion.identity);
    }
}
