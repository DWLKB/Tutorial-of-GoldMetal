public class Actor
{
    //�Ʒ��� ��� ������ �Լ�

    //Ŭ���� ��, '�ڷ�� ����'���� private��� �����ڰ� �����Ǿ� ����
    //private: �ܺ� Ŭ������ ������� �����ϴ� ������
    //�׷��� �߰����� �Է��� ������ Ŭ���� ��� ������ ������ �� ������.
    //public: �ܺ� Ŭ������ ������ �����ϴ� ������ (�� �� Ŭ���� �տ��� ������)
    //����, ������ ���� ��� ������ �Լ� �տ� public �Է��ϱ�

    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "��ȭ�� �ɾ����ϴ�.";
    }

    public string HasWeapon()
    {
        return weapon; 
    }

    public void LevelUp()
    {
        level = level + 1;
    }
}

