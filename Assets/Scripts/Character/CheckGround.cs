using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool colPies;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Terreno") colPies = true;

        if (collision.tag == "Platforms") colPies = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Terreno") colPies = false;

        if (collision.tag == "Platforms") colPies = false;
    }
}