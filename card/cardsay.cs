﻿using UnityEngine;
using System.Collections;

public class cardsay : MonoBehaviour {

	// Use this for initialization

	/*  Wind
Keyboard
Percussion
Chordophone
Extra*/
	public static string[,] cardid = new string[81,2];

	void Start () {

		cardid [1,0] = "調音─打擊";
		cardid [2,0] = "演奏的準備─打擊";
		cardid [3,0] = "演奏開始─打擊";
		cardid [4,0] = "調音─弦鳴";
		cardid [5,0] = "演奏的準備─弦鳴";
		cardid [6,0] = "演奏開始─弦鳴";
		cardid [7,0] = "調音─氣鳴";
		cardid [8,0] = "演奏的準備─氣鳴";
		cardid [9,0] = "演奏開始─氣鳴";
		cardid [10,0] = "調音─鍵盤";
		cardid [11,0] = "演奏的準備─鍵盤";
		cardid [12,0] = "演奏開始─鍵盤";
		cardid [13,0] = "回音─打擊";
		cardid [14,0] = "賦格─打擊";
		cardid [15,0] = "安可─打擊";
		cardid [16,0] = "回音─弦鳴";
		cardid [17,0] = "賦格─弦鳴";
		cardid [18,0] = "安可─弦鳴";
		cardid [19,0] = "回音─氣鳴";
		cardid [20,0] = "賦格─氣鳴";
		cardid [21,0] = "安可─氣鳴";
		cardid [22,0] = "回音─鍵盤";
		cardid [23,0] = "賦格─鍵盤";
		cardid [24,0] = "安可─鍵盤";
		cardid [25,0] = "次強音─打擊";
		cardid [26,0] = "強音─打擊";
		cardid [27,0] = "最強音─打擊";
		cardid [28,0] = "次強音─弦鳴";
		cardid [29,0] = "強音─弦鳴";
		cardid [30,0] = "最強音─弦鳴";
		cardid [31,0] = "次強音─氣鳴";
		cardid [32,0] = "強音─氣鳴";
		cardid [33,0] = "最強音─氣鳴";
		cardid [34,0] = "次強音─鍵盤";
		cardid [35,0] = "強音─鍵盤";
		cardid [36,0] = "最強音─鍵盤";
		cardid [37,0] = "伴奏";
		cardid [38,0] = "合奏";
		cardid [39,0] = "手錶的調整";
		cardid [40,0] = "手錶的調整";
		cardid [41,0] = "手錶的調整";
		cardid [42,0] = "時鐘的調校";
		cardid [43,0] = "時鐘的調校";
		cardid [44,0] = "時鐘的調校";
		cardid [45,0] = "時間的調律";
		cardid [46,0] = "時間的調律";
		cardid [47,0] = "時間的調律";
		cardid [48,0] = "耳塞";
		cardid [49,0] = "吸音棉";
		cardid [50,0] = "防音壁";
		cardid [51,0] = "黑霧";
		cardid [52,0] = "黑霧";
		cardid [53,0] = "黑霧";
		cardid [54,0] = "斑駁的樂譜";
		cardid [55,0] = "指揮的消失";
		cardid [56,0] = "聽覺的喪失";
		cardid [57,0] = "取與捨的巧思";
		cardid [58,0] = "強制接收";
		cardid [59,0] = "危機的警覺";
		cardid [60,0] = "死神的預告";
		cardid [61,0] = "亡者的呼喚";
		cardid [62,0] = "屬性消除";
		cardid [63,0] = "魔力喪失";
		cardid [64,0] = "定時炸彈";
		cardid [65,0] = "定時炸彈";
		cardid [66,0] = "定時炸彈";
		cardid [67,0] = "長花音";
		cardid [68,0] = "短花音";
		cardid [69,0] = "顫音";
		cardid [70,0] = "Roar of soul";
		cardid [71,0] = "弱點調查";
		cardid [72,0] = "Power advance";
		cardid [73,0] = "Reload";
		cardid [74,0] = "one for one";
		cardid [75,0] = "Destiny draw";
		cardid [76,0] = "打擊專屬";
		cardid [77,0] = "弦鳴專屬";
		cardid [78,0] = "氣鳴專屬";
		cardid [79,0] = "鍵盤專屬";
		cardid [80,0] = "起源之音";
		cardid [1,1] = "五秒內,所有節奏珠轉為打擊珠";
		cardid [2,1] = "十秒內,所有節奏珠轉為打擊珠";
		cardid [3,1] = "十五秒內,所有節奏珠轉為打擊珠";
		cardid [4,1] = "五秒內,所有節奏珠轉為弦鳴珠";
		cardid [5,1] = "十秒內,所有節奏珠轉為弦鳴珠";
		cardid [6,1] = "十五秒內,所有節奏珠轉為弦鳴珠";
		cardid [7,1] = "五秒內,所有節奏珠轉為氣鳴珠";
		cardid [8,1] = "十秒內,所有節奏珠轉為氣鳴珠";
		cardid [9,1] = "十五秒內,所有節奏珠轉為氣鳴珠";
		cardid [10,1] = "五秒內,所有節奏珠轉為鍵盤珠";
		cardid [11,1] = "十秒內,所有節奏珠轉為鍵盤珠";
		cardid [12,1] = "十五秒內,所有節奏珠轉為鍵盤珠";
		cardid [13,1] = "七秒內,所有節奏珠轉為打擊珠，並且掉落量變成兩倍";
		cardid [14,1] = "十秒內,所有節奏珠轉為打擊珠，並且掉落量變成兩倍";
		cardid [15,1] = "十三秒內,所有節奏珠轉為打擊珠，並且掉落量變成兩倍";
		cardid [16,1] = "七秒內,所有節奏珠轉為弦鳴珠，並且掉落量變成兩倍";
		cardid [17,1] = "十秒內,所有節奏珠轉為弦鳴珠，並且掉落量變成兩倍";
		cardid [18,1] = "十三秒內,所有節奏珠轉為弦鳴珠，並且掉落量變成兩倍";
		cardid [19,1] = "七秒內,所有節奏珠轉為氣鳴珠，並且掉落量變成兩倍";
		cardid [20,1] = "十秒內,所有節奏珠轉為氣鳴珠，並且掉落量變成兩倍";
		cardid [21,1] = "十三秒內,所有節奏珠轉為氣鳴珠，並且掉落量變成兩倍";
		cardid [22,1] = "七秒內,所有節奏珠轉為鍵盤珠，並且掉落量變成兩倍";
		cardid [23,1] = "十秒內,所有節奏珠轉為鍵盤珠，並且掉落量變成兩倍";
		cardid [24,1] = "十三秒內,所有節奏珠轉為鍵盤珠，並且掉落量變成兩倍";
		cardid [25,1] = "十五秒內,打擊珠的傷害變成原來的150%";
		cardid [26,1] = "十三秒內,打擊珠的傷害變成原來的200%";
		cardid [27,1] = "十秒內,打擊珠的傷害變成原來的300%";
		cardid [28,1] = "十五秒內,弦鳴珠的傷害變成原來的150%";
		cardid [29,1] = "十三秒內,弦鳴珠的傷害變成原來的200%";
		cardid [30,1] = "十秒內,弦鳴珠的傷害變成原來的300%";
		cardid [31,1] = "十五秒內,氣鳴珠的傷害變成原來的150%";
		cardid [32,1] = "十三秒內,氣鳴珠的傷害變成原來的200%";
		cardid [33,1] = "十秒內,氣鳴珠的傷害變成原來的300%";
		cardid [34,1] = "十五秒內,鍵盤珠的傷害變成原來的150%";
		cardid [35,1] = "十三秒內,鍵盤珠的傷害變成原來的200%";
		cardid [36,1] = "十秒內,鍵盤珠的傷害變成原來的300%";
		cardid [37,1] = "十三秒內,全部種類的傷害變成原來的150%";
		cardid [38,1] = "十秒內,全部種類的傷害變成原來的200%";
		cardid [39,1] = "低音點施放:五秒內,自身的節奏珠速度變成原來的150%;高音點施放:五秒內,對手的節奏珠速度變成現在的75%";
		cardid [40,1] = "低音點施放:十秒內,自身的節奏珠速度變成原來的150%;高音點施放:十秒內,對手的節奏珠速度變成現在的75%";
		cardid [41,1] = "低音點施放:十五秒內,自身的節奏珠速度變成原來的150%;高音點施放:十五秒內,對手的節奏珠速度變成現在的75%";
		cardid [42,1] = "低音點施放:五秒內,自身的節奏珠速度變成原來的200%;高音點施放:五秒內,對手的節奏珠速度變成現在的50%";
		cardid [43,1] = "低音點施放:十秒內,自身的節奏珠速度變成原來的200%;高音點施放:十秒內,對手的節奏珠速度變成現在的50%";
		cardid [44,1] = "低音點施放:十五秒內,自身的節奏珠速度變成原來的200%;高音點施放:十五秒內,對手的節奏珠速度變成現在的50%";
		cardid [45,1] = "低音點施放:五秒內,自身的節奏珠速度變成原來的300%;高音點施放:五秒內,對手的節奏珠速度變成現在的25%";
		cardid [46,1] = "低音點施放:十秒內,自身的節奏珠速度變成原來的300%;高音點施放:十秒內,對手的節奏珠速度變成現在的25%";
		cardid [47,1] = "低音點施放:十五秒內,自身的節奏珠速度變成原來的300%;高音點施放:十五秒內,對手的節奏珠速度變成現在的25%";
		cardid [48,1] = "三秒內,對自身傷害變為0";
		cardid [49,1] = "四秒內,對自身傷害變為0";
		cardid [50,1] = "五秒內,對自身傷害變為0";
		cardid [51,1] = "低音點施放:在對方低音點產生一個黑霧持續十秒;高音點施放:在對方高音點產生一個黑霧持續十秒";
		cardid [52,1] = "低音點施放:在對方低音點產生一個黑霧持續十三秒;高音點施放:在對方高音點產生一個黑霧持續十三秒";
		cardid [53,1] = "低音點施放:在對方低音點產生一個黑霧持續十五秒;高音點施放:在對方高音點產生一個黑霧持續十五秒";
		cardid [54,1] = "五秒內,降低對方節奏珠的可見度";
		cardid [55,1] = "七秒內,降低對方節奏珠的可見度";
		cardid [56,1] = "十秒內,降低對方節奏珠的可見度";
		cardid [57,1] = "低音點施放:吸收對手版面上的節奏珠;高音點施放：將自己版上現有的節奏珠給對手";
		cardid [58,1] = "低音點施放:十秒內,對手只能用低音點打擊;高音點施放:十秒內,對手只能用高音點打擊";
		cardid [59,1] = "低音點施放:五秒內,提升對手毒珠出現的機率;高音點施放:短時間內提升將對手場上的節奏珠轉為毒珠的機率";
		cardid [60,1] = "低音點施放:十秒內,提升對手毒珠出現的機率;高音點施放:一小段時間內提升將對手場上的節奏珠轉為毒珠的機率";
		cardid [61,1] = "低音點施放:十五秒內，提升對手毒珠出現的機率;高音點施放:一段時間內提升將對手場上的節奏珠轉為毒珠的機率";
		cardid [62,1] = "三秒內,對手節奏珠變為無效珠";
		cardid [63,1] = "五秒內,對手節奏珠變為無效珠";
		cardid [64,1] = "十秒內,對手必須達成15Combo,否則將會受到少量傷害";
		cardid [65,1] = "十五秒內,對手必須達成15Combo,否則將會受到大量傷害";
		cardid [66,1] = "二十秒內,對手必須達成15Combo,否則將會受到巨量傷害";
		cardid [67,1] = "五秒內,一個節奏珠必須擊中兩次才能消除";
		cardid [68,1] = "十秒內,一個節奏珠必須擊中兩次才能消除";
		cardid [69,1] = "十五秒內,一個節奏珠必須擊中兩次才能消除";
		cardid [70,1] = "十秒內,在低音點擊中少量節奏珠吸收對手一個節奏珠;在高音點擊中一些節奏珠吹走對手兩個節奏珠";
		cardid [71,1] = "低音點施放:前五秒,對手擊中節奏珠可回血,後五秒,自身的傷害變為兩倍且無視對方防禦;高音點施放:前五秒,對手傷害變為兩倍,後五秒,對手的傷害轉為回復自身生命";
		cardid [72,1] = "低音點施放:十秒內,自身傷害變為400%,效果結束後自身的生命減半;高音點施放:生命變為最大生命的一半,傷害上升150%,防禦降為50%";
		cardid [73,1] = "Each player discards their cards in hand,and draw some number of cards their discarded";
		cardid [74,1] = "Rendom destroy a card in enemy's hand";
		cardid [75,1] = "Rendom discard a card on your hand and draw 2 cards";
		cardid [76,1] = "The rhythm with speed and super power";
		cardid [77,1] = "10秒內,擊中低音點十次可以降對手10%最大防禦,擊中高音點各吸收對手攻擊,防禦,回復2%轉為自身的防禦";
		cardid [78,1] = "The breath uninterrupted";
		cardid [79,1] = "The timbre vast as the cosmos";
		cardid [80,1] = "起源之音";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


