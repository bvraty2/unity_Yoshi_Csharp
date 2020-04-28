using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    public Person person1;
    public Person person2;
    private void Start()
    {
        person1.Talk();
        person2.Talk();

        print("屁孩 BMI:" + person1.BMI());
        print("專殺黑人 BMI:" + person2.BMI());

        person1.Walk(99, sound: "嘎嘎嘎");
        person2.Walk(10, "左邊");

        person1.Attack();
        person2.Attack("沙漠之鷹");

    }
}
