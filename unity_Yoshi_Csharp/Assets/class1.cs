using UnityEngine; // 引用 Unity API (函式庫：Unity 屬性、功能...)

//類別 class 定義一個物件
//語法：class 類別名稱
//：Monobehaviour 可以將此腳本掛在 Unity 物件上
// 類別必須放在物件上才會執行
public class class1 : MonoBehaviour
{
    // 定義類別成員
    // C#
    // 1. 大小不一樣
    // 2. 括號成對出現 () [] {} '' "" < >

    [Header("汽車一號")]
    public Car car1;

    [Header("汽車二號")]
    public Car car2;


    
    // 事件：在特定時間會以指定次數執行的方法 (名稱為藍色)
    // 開始事件：播放遊戲時執行一次 - 初始設定
    private void Start()
    {
        // 輸出("文字訊息")
        // C# 結尾為分號 ;
        print("ㄩㄇ");

        // 取得 get
        print("汽車一號的CC數是"+ car1.cc);
        print("汽車二號的品牌是"+ car2.brand);

        // 設定 set
        car1.cc = 678;
        car1.brake = true;
        car1.weight = 666.6f;
        car1.brand = "gogoro";

    }
}
