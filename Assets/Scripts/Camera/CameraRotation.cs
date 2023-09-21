using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BarkworksUtilities.GamePlay2D
{
    public class CameraRotation : MonoBehaviour
    {

        public int rotationAngle = 0;

        // Update is called once per frame
        void Update()
        {
            transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
        }
    }
}