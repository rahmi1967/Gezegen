using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun; // G�ne�in Transform bile�eni
    public float orbitSpeed = 1f; // Gezegenlerin d�nme h�z� (derece/saniye)
    public float distanceFromSun = 5f; // Gezegenin G�ne�e olan uzakl���

    void Update()
    {
        // Gezegenin G�ne� etraf�nda d�nmesi
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // Gezegenin sabit bir mesafede G�ne�e bakmas� (opsiyonel)
        transform.LookAt(sun);
        transform.Rotate(Vector3.right, 90f); // E�er gezegen y�zeyi d�z bir yap�daysa bu kodu kullan�n, yoksa yorum sat�r�na al�n
    }
}

