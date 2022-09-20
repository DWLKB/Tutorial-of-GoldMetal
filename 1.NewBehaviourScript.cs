using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour //MonoBehaviour: ����Ƽ ���� ������Ʈ Ŭ����
{
    
    //��������(�������): �Լ� �ٱ��� ����� ����
    //����� �ʼ������ʹ� ���������� �ø���
    int health = 30;
    int level = 5;
    float strength = 15.5f;
    string playerName = "���˻�";
    bool isFullLevel = false;
    int exp = 1500;
    string title = "������";
    int mana = 25;


    void Start()
    {
        Debug.Log("Hello Unity!");



        //1. ����: 4���� �ڷ���(������)
        int level = 5; //������
        float strength = 15.5f; //������(f ���̱�)
        string playerName = "���˻�"; //���ڿ�(""���̱�)
        bool isFullLevel = false; //����

        //���α׷����� ����(�̸����ϱ�)>�ʱ�ȭ(���� �ִ°�)>ȣ��(���)
        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);



        //2. �׷��� ����
        //�迭
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        Debug.Log(monsters[0]); //���α׷��ֿ��� ���ۼ����� 0
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        int[] monsterLevel = new int[3]; //[]���� �迭�� ũ��
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ������ ����");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);


        //����Ʈ: ����� �߰��� ������ �׷��� ����
        List<string> items = new List<string>(); //<>���� �ڷ���
        items.Add("������30");
        items.Add("��������30");

        //�迭���� �ٸ��� ������ ���� ����(0�� ������� 1�� 0��°�� �ȴ�)
        items.RemoveAt(0);

        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);



        //3. ������: ���, �������� �������ִ� ��ȣ
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level= exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);

        //������(%)�� ���� �ƴ� �������� ���
        int nextExp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);


        //���ڿ��� ���� ������
        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);


        //�� ������(>�ʰ�, <�̸�, >=�̻�, <=����)
        int fullLevel = 99;
        isFullLevel = level == fullLevel; //������ ���� �� ==
        Debug.Log("���� �����Դϱ�?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + isEndTutorial);


        //�����Ῥ����(&&): �� ���� ��� true�϶��� true
        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;

        //OR(||): �� �� �߿��� �ϳ��� true�� true
        bool isBadCondition = health <= 50 || mana <= 20;

        //'? A : B': true �� �� A, false�� �� B ���
        string condition = isBadCondition ? "����" : "����";
        Debug.Log("����� ���´� ���޴ϱ�?" + isBadCondition);



        //4. Ű����: ���α׷��� �� �����ϴ� Ư���� �ܾ�(�����̸�, �����ε� ���Ұ�)
        //int float string bool new List
        //int float = 1 (X)
        //string name = List (X)



        //5. ���ǹ�
        //if��: (bool ��������)������ true�� ��, ���� ����.
        if (condition == "����") 
        {
            Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
        }
        else //���� if�� ���� �ȵ� �� ����
        {
            Debug.Log("�÷��̾� ���°� �����ϴ�.");
        }
        if (isBadCondition && items[0] == "������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        else if (isBadCondition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }


        //switch, case: �������� ���� ���� ����
        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            //default: ��� case ��� �� ����
            default:
                Debug.Log("??? ���Ͱ� ����!");
                break;
        }



        //6. �ݺ���
        //while: ������ true�� ��, ���� �ݺ� ����
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�." + health);
            else
                Debug.Log("����ϼ̽��ϴ�.");

            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break; //break�� �������Ͷ�� ��� Ű����
            }
        }


        //for: ������ �����ϸ鼭 ���� �ݺ� ����
        //��ȣ �ȿ��� (����� ���� ; ���� ; ����)
        for (int count=0 ; count<10 ; count++) 
        {
            health++;
            Debug.Log("�ش�� ġ����..." + health);
        }

        //for���� ������ �׷��� �������� ����
        //�׷������� ����: length(�迭), count(����Ʈ)
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("�� ������ �ִ� ���� : " + monsters[index]); //������ �������� ���
        }


        //foreach: for�� �׷������� Ž�� Ưȭ(���� �׷������� �ȿ� �ִ� �������� �ϳ��� ������)
        foreach (string monster in monsters)
        {
            Debug.Log("�� ������ �ִ� ���� : " + monster);
        }

        //health = Heal(health); �̰Ŵ� 1��° �Լ� ����
        Heal();

        //���� 3������ �迭�� ��������� for�� ����ϱ�
        for (int index = 0 ; index < monsters.Length ; index++)
        {
            Debug.Log("����" + monsters[index] + "����" +
                Battle(monsterLevel[index]));
        }



        //8. Ŭ����: �ϳ��� �繰(������Ʈ)�� �����ϴ� ����(1���� class, 1���� ����)
        //class: Ŭ���� ���� ���(Actor ���� ����)
        //Actor player = new Actor();
        Player player = new Player();
        //Ŭ������ ������ ����. �̸� �ν��Ͻ�: ���ǵ� Ŭ������ ���� �ʱ�ȭ�� ��üȭ
        //������ ������ �� Ÿ���� ���� �� ��� Ŭ���� �̸� ���ֱ�
        //new(����������): �⺻ Ŭ�������� ��ӵ� ����� ��������� ����
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + "�Դϴ�.");
        Debug.Log(player.move());

        //�׷��� �� ���� �ִ� �ν��Ͻ� �� ���忡 ': MonoBehaviour'�� ����?
        //�츮�� ���� Class Actor�� ����� ���� ������ ���� �ִ�.
        //�츮�� Actor��� Ŭ������ �Ǵٸ� Ŭ������ ���� ���� �ִ�.
        //Player ����ó�� ����� �� 223�� ActorŬ���� ��� PlayerŬ������ �ٲ㵵 ���� ����
        //����ó�� ': Actor'�� ��������ν� Actor Ŭ���� ���� �ִ� ��� ������ �Լ��� �� PlayerŬ������ �����޾Ƽ� ����� �� �ִ�.
        //��Ӱ���: ActorŬ������ �θ�class�� �ǰ�, PlayerŬ������ �ڽ�class�� �ȴ�.
        //�ڽ� Ŭ������ �θ� Ŭ������ �ִ� ��� ��� ������ �Լ��� ����� ���� �����鼭��
        //�ڱ��ڽ��� ���ο� ��� ������ �Լ��� �߰��� ��밡���ϴ�
        //����� ': MonoBehaviour'�� ���� �츮�� ���α׷����� �̰��� �ٷ� ����Ƽ Ŭ������ ����� Ŭ�����ٶ�� �ǹ�
    }

    //7. �Լ�(�޼ҵ�): ����� ���ϰ� ����ϵ��� ������ ����
    int Heal(int currentHealth) //��ȣ�ȿ��� �Ű������� ��. ���������̸��� �����ʿ�X
    {
        currentHealth += 10;
        Debug.Log("���� �޾ҽ��ϴ�." + currentHealth);
        return currentHealth;  //return: �Լ��� ���� ��ȯ�� �� ���
    }

    //���� �ް� ��ȯ�� �ʿ� ���� ����ϱ⸸ �ص� ���� �޴� �������� �Լ�
    void Heal() //void: ��ȯ �����Ͱ� ���� �Լ� Ÿ��
    {
        health += 10; 
        //Heal�Լ��� ���忡���� start�Լ� �ȿ� �ִ� health�� �� ����
        //�̴� ��������: �Լ� �ȿ��� ����� ����(�ٸ��Լ��� ���ٺҰ�)
        //���� start �Լ� ���� �������� ����
        Debug.Log("���� �޾ҽ��ϴ�." + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�.";

        return result;
    }
}
