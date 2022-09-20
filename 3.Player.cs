using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor 
    //': Actor'을 사용함으로써 Actor 클래스 내에 있는 멤버 변수와 함수를 이 Player클래스가 물려받아서 사용할 수 있다.
{
    public string move()
    {
        return "플레이어는 움직입니다.";
    }
}
