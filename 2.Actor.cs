public class Actor
{
    //아래는 멤버 변수와 함수

    //클래스 내, '자료명 변수'에는 private라는 접근자가 생략되어 있음
    //private: 외부 클래스에 비공개로 설정하는 접근자
    //그래서 추가적인 입력이 없으면 클래스 멤버 변수에 접근할 수 없었다.
    //public: 외부 클래스에 공개로 설정하는 접근자 (맨 위 클래스 앞에도 적힌다)
    //따라서, 다음과 같이 멤버 변수와 함수 앞에 public 입력하기

    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
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

