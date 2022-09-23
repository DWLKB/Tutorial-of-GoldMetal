using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class OtherBalls : MonoBehaviour
{
    //���� ����
    //MeshRenderer: ������Ʈ�� ���� ����
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        //�ʱ�ȭ ����
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    //#1.���� �浹 �̺�Ʈ(�ۿ� �α�)_���� ������ �浹�� �߻��ϴ� �̺�Ʈ
    //OnCollisionEnter: ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    //OnCollisionStay: �浹�� �� ������ ��
    //OnCollisionExit: ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    //Collision:�浹 ���� Ŭ����
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


    //#2.Ʈ���� �̺�Ʈ�� My Ball ��ũ��Ʈ����!
}
    

