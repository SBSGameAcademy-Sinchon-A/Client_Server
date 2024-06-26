using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] UIPanels;

    /// <summary>
    /// 인게임 내의 UI / 0 : hp bar , 1 : mp bar
    /// </summary>
    public GameObject[] ingameUIPanels;

    Stack<int> userInterfaceStack = new Stack<int>();

    PlayerStatus PlayerStatus;

    void Start()
    {
        PlayerStatus = Singleton.instance.GetComponentInChildren<PlayerStatus>();
    }

    void Update()
    {
        
    }

    public void EscapeUI()
    {
        if (userInterfaceStack.Count == 0)
        {

        }
        else
        {
            if (userInterfaceStack.Count == 1)
            {
                Time.timeScale = 1f;
            }

            UIPanels[userInterfaceStack.Pop()].SetActive(false);
        }
    }



    public void RenewIngameUI()
    {
        ingameUIPanels[0].GetComponent<Image>().fillAmount = PlayerStatus.hp / PlayerStatus.maxHp;
        ingameUIPanels[1].GetComponent<Image>().fillAmount = PlayerStatus.mp / PlayerStatus.maxMp;
    }
}
