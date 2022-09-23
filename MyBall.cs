using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    //���� �༭ �����̰� �ϴ� �Ϳ��� RigidBody�� �߿�

    Rigidbody rigid;  //���� ����

    void Start()
    {
        //���� �ȿ��� ����Ʈó�� ����Ÿ���� �����.
        rigid = GetComponent<Rigidbody>();  //�ʱ�ȭ ����

    }

    void FixedUpdate()
    {
        //#1.�ӷ� �ٲٱ�
        //velocity: �����̵��ӵ�(����3)
        rigid.velocity = Vector3.left;
        rigid.velocity = new Vector3(2, 4, 3);

        //Update���� ������ �ӵ� ������
        //������, RigidBody ���� �ڵ�� FixedUpdate�� �ۼ��ϱ�!
       


        //#2.���� ���ϱ�
        if (Input.GetButtonDown("Jump"))
        {
            //AddFordce(Vec): Vec�� ����� ũ��� ���� ��
            //��ǥ �� ���� �Ű����� �� ���� �� ����
            //ForceMode: ���� �ִ� ���(����, ���� �ݿ�)
            //���� ���� Ŭ���� �����̴µ� �� ���� �� �ʿ�.
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical"); 
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);



        //#3.ȸ����
        //AddTorque(vec): Vec������ ������ ȸ������ ����
        rigid.AddTorque(Vector3.up);  //up�� (0,1,0)�̹Ƿ� ����ó�� ȸ��
    }



    //#2.Ʈ���� �̺�Ʈ(�ۿ� �α�)_�ݶ��̴� �浹�� �߻��ϴ� �̺�Ʈ
    //�ش� ������ Box Collider���� Is Trigger üũ
    //OnTriggerStay: �ݶ��̴��� ��� �浹�ϰ� ���� �� ȣ��(Enter, Exit ����)
    //�浹�̺�Ʈó�� �Ű������� Collision�� �ƴ� Collider�� ������ ontrigger�� �������� �浹�� �ƴ϶� Collider�� ���ƴ����� ���°��̱� �����̴�.
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

