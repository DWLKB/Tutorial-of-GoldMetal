using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        //오늘 배울 건 Vector3 클래스에서 제공하는 이동 함수
        //Update에서 사용하기


        //1.MoveTowards: 등속이동
        //매개변수는(현재위치, 목표위치, 속도)
        //마지막 매개변수에 비례하여 속도 증가
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);


        //2.SmoothDamp: 쭉 가다가 부드럽게 도착하는
        //매개변수는(현재위치, 목표위치, 참조속도, 속도)
        //마지막 매개변수에 반비례하여 속도 증가
        Vector3 velo = Vector3.zero;  //SmoosthDamp쓸땐 zero씀(up *50으로하면 타겟의 의미없어짐)

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        

        //3.Lerp: 선형보간, SmmoothDamp보다 감속시간이 김
        //매개변수는 MoveTowards과 동일
        //마지막 매개변수에 비례하여 속도 증가(최대값1)
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);


        //4.Slerp: 구면선형보간, 호를 그리며 이동(포물선이동)
        //포물선으로 이동하는 것 외엔 Lerp와 같음.
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f); 




        //Time.deltaTime: 이전 프레임의 완료까지 걸린 시간
        //이 값은 프레임이 적으면 크고, 프레임이 많으면 작음(이동거리를 공평하게!)
        //따라서 이걸 사용하면 사양(프레임)이 좋든 않좋든 동일한 속도를 줌

        //Translate: 벡터에 곱하기 > transform.Translate(Vec*Time.deltaTime)
        //Vector 함수: 시간 매개변수에 곱하기 > Vector3.Lerp(Ver1, Ver2, T*Time.deltaTime)

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        transform.Translate(vec);



    }
}
