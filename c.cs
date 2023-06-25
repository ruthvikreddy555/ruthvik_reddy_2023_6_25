using System;
using UnityEngine;
using UnityEngine.UI;

public class c : MonoBehaviour
{
    public Text resultText;
    public float num1;
    public float num2;
    public float gt = 0f;
    public float mrc = 0f;
    public float mp = 0f;
    public float mm = 0f;
    public float a = 0f;
    public string operation;

    

    public void Add()
    {
        num1 = float.Parse(resultText.text);
        operation = "+";
        resultText.text = "";
    }

    public void Subtract()
    {
        num1 = float.Parse(resultText.text);
        operation = "-";
        resultText.text = "";
    }

    public void Multiply()
    {
        num1 = float.Parse(resultText.text);
        operation = "*";
        resultText.text = "";
    }

    public void Divide()
    {
        num1 = float.Parse(resultText.text);
        operation = "/";
        resultText.text = "";


    }
    public void b1()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "1";
        }
        else
        {
            resultText.text = resultText.text + "1";
        }

    }
    public void b2()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "2";
        }
        else
        {
            resultText.text = resultText.text + "2";
        }

    }
    public void b3()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "3";
        }
        else
        {
            resultText.text = resultText.text + "3";
        }

    }
    public void b4()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "4";
        }
        else
        {
            resultText.text = resultText.text + "4";
        }

    }
    public void b5()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "5";
        }
        else
        {
            resultText.text = resultText.text + "5";
        }

    }
    public void b6()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "6";
        }
        else
        {
            resultText.text = resultText.text + "6";
        }

    }
    public void b7()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "7";
        }
        else
        {
            resultText.text = resultText.text + "7";
        }

    }
    public void b8()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "8";
        }
        else
        {
            resultText.text = resultText.text + "8";
        }

    }
    public void b9()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "9";
        }
        else
        {
            resultText.text = resultText.text + "9";
        }

    }
    public void b0()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "0";
        }
        else
        {
            resultText.text = resultText.text + "0";
        }

    }
    public void b00()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "00";
        }
        else
        {
            resultText.text = resultText.text + "00";
        }

    }
    public void bdot()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = ".";
        }
        else
        {
            resultText.text = resultText.text + ".";
        }

    }
    public void equaloper()
    {
        
        num2 = float.Parse(resultText.text);

        if (operation == "+")
        {
            a = num1 + num2;
            resultText.text = a.ToString();
        }
        if (operation == "-")
        {
            a = num1 - num2;
            resultText.text = a.ToString();
        }
        if (operation == "*")
        {
            a = num1 * num2;
            resultText.text = a.ToString();
        }
        if (operation == "/")
        {
            a = num1 / num2;
            resultText.text = a.ToString();
        }      
    }
    public void clear()
    {
        resultText.text = "0";
    }       
}
