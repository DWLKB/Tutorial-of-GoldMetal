using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        //���� ��� �� Vector3 Ŭ�������� �����ϴ� �̵� �Լ�
        //Update���� ����ϱ�


        //1.MoveTowards: ����̵�
        //�Ű�������(������ġ, ��ǥ��ġ, �ӵ�)
        //������ �Ű������� ����Ͽ� �ӵ� ����
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);


        //2.SmoothDamp: �� ���ٰ� �ε巴�� �����ϴ�
        //�Ű�������(������ġ, ��ǥ��ġ, �����ӵ�, �ӵ�)
        //������ �Ű������� �ݺ���Ͽ� �ӵ� ����
        Vector3 velo = Vector3.zero;  //SmoosthDamp���� zero��(up *50�����ϸ� Ÿ���� �ǹ̾�����)

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        

        //3.Lerp: ��������, SmmoothDamp���� ���ӽð��� ��
        //�Ű������� MoveTowards�� ����
        //������ �Ű������� ����Ͽ� �ӵ� ����(�ִ밪1)
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);


        //4.Slerp: ���鼱������, ȣ�� �׸��� �̵�(�������̵�)
        //���������� �̵��ϴ� �� �ܿ� Lerp�� ����.
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f); 




        //Time.deltaTime: ���� �������� �Ϸ���� �ɸ� �ð�
        //�� ���� �������� ������ ũ��, �������� ������ ����(�̵��Ÿ��� �����ϰ�!)
        //���� �̰� ����ϸ� ���(������)�� ���� ������ ������ �ӵ��� ��

        //Translate: ���Ϳ� ���ϱ� > transform.Translate(Vec*Time.deltaTime)
        //Vector �Լ�: �ð� �Ű������� ���ϱ� > Vector3.Lerp(Ver1, Ver2, T*Time.deltaTime)

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        transform.Translate(vec);



    }
}
