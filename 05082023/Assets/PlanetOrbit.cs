using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun; // Güneþin Transform bileþeni
    public float orbitSpeed = 1f; // Gezegenlerin dönme hýzý (derece/saniye)
    public float distanceFromSun = 5f; // Gezegenin Güneþe olan uzaklýðý

    void Update()
    {
        // Gezegenin Güneþ etrafýnda dönmesi
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // Gezegenin sabit bir mesafede Güneþe bakmasý (opsiyonel)
        transform.LookAt(sun);
        transform.Rotate(Vector3.right, 90f); // Eðer gezegen yüzeyi düz bir yapýdaysa bu kodu kullanýn, yoksa yorum satýrýna alýn
    }
}

