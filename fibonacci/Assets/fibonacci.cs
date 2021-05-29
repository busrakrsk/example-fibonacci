
using UnityEngine;

using TMPro;



public class fibonacci : MonoBehaviour
{

    public TMP_InputField user_input;
    long max_number = 0;

    public AudioClip click;

    public TextMeshProUGUI display_value_textholder;

    public void Add_Fibonacci()
    {
        max_number += 1;
        GetFibonacci(max_number, display_value_textholder);
    }

    public void Fibonacci_Func()
    {
        max_number = long.Parse(user_input.text);

        GetFibonacci(max_number, display_value_textholder);

    }


    private void GetFibonacci(long num, TextMeshProUGUI display_value)
    {
        long t1 = 0;
        long t2 = 1;
        long t_total = 0;

        display_value.text = "The Series:    ";

        for (int i = 1; i <= num; i++)
        {
            if (i == 1)
            {
                display_value.text += t1 + ", ";
            }
            else if (i == 2)
            {
                display_value.text += t2 + ", ";
            }
            else
            {
                t_total = t1 + t2;
                t1 = t2;
                t2 = t_total;

                display_value.text += t_total + ", ";
            }

        }

    }

    public void QuitGame()
    {
        Application.Quit();

    }


   

    public void PlaySound()
    {
        GameObject.FindGameObjectWithTag("GameControlle").GetComponent<AudioSource>().PlayOneShot(click);
    }

}



