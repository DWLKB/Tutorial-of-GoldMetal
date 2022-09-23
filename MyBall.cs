using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    //힘을 줘서 움직이게 하는 것에서 RigidBody가 중요

    Rigidbody rigid;  //선언 과정

    void Start()
    {
        //꺽새 안에는 리스트처럼 변수타입을 써야함.
        rigid = GetComponent<Rigidbody>();  //초기화 과정

    }

    void FixedUpdate()
    {
        //#1.속력 바꾸기
        //velocity: 현재이동속독(벡터3)
        rigid.velocity = Vector3.left;
        rigid.velocity = new Vector3(2, 4, 3);

        //Update에서 받으면 속도 유지됨
        //하지만, RigidBody 관련 코드는 FixedUpdate에 작성하기!
       


        //#2.힘을 가하기
        if (Input.GetButtonDown("Jump"))
        {
            //AddFordce(Vec): Vec의 방향과 크기로 힘을 줌
            //쉼표 더 쓰면 매개변수 더 놓을 수 있음
            //ForceMode: 힘을 주는 방식(가속, 무게 반영)
            //무게 값이 클수록 움직이는데 더 많은 힘 필요.
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical"); 
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);



        //#3.회전력
        //AddTorque(vec): Vec방향을 축으로 회전력이 생김
        rigid.AddTorque(Vector3.up);  //up이 (0,1,0)이므로 팽이처럼 회전
    }



    //#2.트리거 이벤트(밖에 두기)_콜라이더 충돌로 발생하는 이벤트
    //해당 공간에 Box Collider에서 Is Trigger 체크
    //OnTriggerStay: 콜라이더가 계속 충돌하고 있을 때 호출(Enter, Exit 있음)
    //충돌이벤트처럼 매개변수가 Collision이 아닌 Collider인 이유는 ontrigger는 물리적인 충돌이 아니라 Collider와 겹쳤는지를 보는것이기 때문이다.
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}

