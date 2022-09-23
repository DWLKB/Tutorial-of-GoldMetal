using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class OtherBalls : MonoBehaviour
{
    //선언 과정
    //MeshRenderer: 오브젝트의 재질 접근
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        //초기화 과정
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    //#1.물리 충돌 이벤트(밖에 두기)_실제 물리적 충돌로 발생하는 이벤트
    //OnCollisionEnter: 물리적 충돌이 시작할 때 호출되는 함수
    //OnCollisionStay: 충돌이 쭉 유지될 때
    //OnCollisionExit: 물리적 충돌이 끝났을 때 호출되는 함수
    //Collision:충돌 정보 클래스
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }


    //#2.트리거 이벤트는 My Ball 스크립트에서!
}
    

