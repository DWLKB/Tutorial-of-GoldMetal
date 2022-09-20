using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //1.�ʱ�ȭ ����: ����Ƽ �����ֱ⿡�� ���� ù��°�� ����
    void Awake() //���� ������Ʈ ������ ��, ���� ����
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void OnEnable() //���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��(���ʽ����� �ƴ� �Ѱ� �� ������ ����)
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    void Start() //������Ʈ ���� ����, ���� ����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }


    //2.�������� ����
    void FixedUpdate()  //����Ƽ ������ ���������� �ϱ� ���� ����Ǵ� ������Ʈ �Լ�
                        //Ư¡: (1s�� 50ȸ ȣ��)������ ���� �ֱ�� CPU�� ���� ���.(���� �������)
    {
        Debug.Log("�̵�~");
    }


    //3.���ӷ��� ����
    void Update()   //���������� ������ ������ �ֱ������� ���ϴ� ������ ������ ���
                    //(60������)ȯ��(���)�� ���� �����ֱⰡ ������ �ִ�.
    {
        Debug.Log("���� ���!!");
    }

    void LateUpdate() //��� ������Ʈ ���� �� ����Ǵ� �Լ�(��ó��)
    {
        Debug.Log("����ġ ȹ��.");
    }


    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }
    //script üũ �����ϸ� �� (�ٽ� üũ�� �����)

    //��ü ����
    void OnDestroy() //���� ������Ʈ�� ������ �� (���� ����� �����)
    {
        Debug.Log("�÷��̾� �����Ͱ� �����Ͽ����ϴ�.");
    }


    //���ӿ�����Ʈ�� �������� �ʰ� �Ѱ� ���� �ִ�.
    //Ȱ��ȭ: �ʱ�ȭ�� ���� ���� ����(��ŸƮ���� ������)
    //��Ȱ��ȭ: ��� ������Ʈ�� �� ���� �� ��Ȱ��ȭ�ϰų� ������ ��





    //Ű���� ���콺�� �̵����Ѻ���!
    void Update()
    {
        //input: ���� �� �Է��� �����ϴ� Ŭ����

        //anykeydown: �ƹ� �Է��� ���ʷ� ���� �� true
        //anykey: �ƹ� �Է��� ������ true

        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        //�� �Է� �Լ��� 3���� �ൿ���� ����: down, stay, up


        //GetKey: Ű���� ��ư �Է��� ������ true (�Ű�����: KeyCode.00)

        if (Input.GetKeyDown(KeyCode.Return)) //Return: ����, Escape: esc
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");


        //GetMouse: ���콺 ��ư �Է��� ������ true

        if (Input.GetMouseButtonDown(0)) //�Ű�����: 0(����), 1(������)
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");


        //������ Ű�� Edit>Project Settings>input manager���� Ȯ��(�ڵ������Ǿ�����)
        //����Ű ���� ����, ����� Ű��� GetButton �Ű����� �����߰� ����

        //GetBuutton: input ��ư �Է��� ������ true
        //�Ű�����: input manager ���� (��ҹ��� �����ؾ���)
        //�������� ����̽� ���ֹ��� �ʰ� ���� �̸����� �������� ����̽��� ���ÿ� ������ �� �ִ�.
        //����ϵ� �̰ɷ� Ŀ�� ����

        if (Input.GetButtonDown("Fire1"))   //���� �� down �Ⱦ�
            Debug.Log("����!");

        if (Input.GetButton("Fire1"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("���� ����!!");


        //Ⱦ �̵��� ��
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..."
                //GetAxis: (����ġ�� �� ��)����, ���� ��ư �Է��� ������ float�� ��ȯ
                //������Ʈ�� ���� transform�� �׻� ������ ����.
                //GetAsixRaw: (����ġX) 1�� -1�� �����Բ�. ���ÿ� ������ 0.
                + Input.GetAxisRaw("Horizontal"));
        }

        //�� �̵��� ��
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..."
                + Input.GetAxisRaw("Vertical"));
        }

    }




    //������Ʈ �̵�
    //Projectâ�� ���� ���ӿ�����Ʈ ���� Transform�� �׻� ���Ե�(1:1����)
    //(Class)Transform: ������Ʈ ���¿� ���� �⺻ ������Ʈ
    //������Ʈ�� ���� transform�� �׻� ������ ����.(�̹� �ʱ�ȯ��. ���� ����X)
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),   //�߰��� �������� GetAxisRaw
            Input.GetAxis("Vertical"), 
            0);

        //Translate: ���Ͱ��� ���� ��ġ�� ���ϴ� (�̵�)�Լ�
        transform.Translate(vec);
    }

}
