using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace BarkworksUtilities.GamePlay2D
{
    public class PlayerMouseRotation : MonoBehaviour
    {
        public float speed = 0.01f;
        private float m_timeCount = 0.0f;

        // Update is called once per frame
        void Update()
        {
            Vector3 mouseScreen = Input.mousePosition;
            Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);

            transform.rotation = Quaternion.Lerp(transform.rotation ,Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90), m_timeCount * speed);
            m_timeCount = m_timeCount + Time.deltaTime;
        }
    }
}