using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Variables
    public float hp;
    public float maxHP;
    [SerializeField]
    private Image bar;

    //Functions
    public void setHP(float newHP)
    { 
        bar.fillAmount = hp/maxHP;
    }
}
