using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] PanelContlloler panelcontlloler;
    private void Start()
    {
        score= GameObject.Find("score").GetComponent<Score>();
        panelcontlloler = GameObject.FindWithTag("Player").GetComponent<PanelContlloler>();
    }
    private void OnCollisionEnter(Collision co)
    {
 
        //触れたタグがゲームオーバーセンサーについている"fruits"なら最終スコアを表示する処理
        if (co.gameObject.tag == "fruits")
        {
            score.PlayScore();
            panelcontlloler.Result();
            Destroy(this.gameObject);
        }

    }
}
