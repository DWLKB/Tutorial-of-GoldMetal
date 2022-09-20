using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour //MonoBehaviour: 유니티 게임 오브젝트 클래스
{
    
    //전역변수(멥버변수): 함수 바깥에 선언된 변수
    //용사의 필수데이터는 전역변수로 올리기
    int health = 30;
    int level = 5;
    float strength = 15.5f;
    string playerName = "나검사";
    bool isFullLevel = false;
    int exp = 1500;
    string title = "전설의";
    int mana = 25;


    void Start()
    {
        Debug.Log("Hello Unity!");



        //1. 변수: 4가지 자료형(데이터)
        int level = 5; //정수형
        float strength = 15.5f; //숫자형(f 붙이기)
        string playerName = "나검사"; //문자열(""붙이기)
        bool isFullLevel = false; //논리형

        //프로그래밍은 선언(이름정하기)>초기화(값을 넣는것)>호출(사용)
        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);



        //2. 그룹형 변수
        //배열
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        Debug.Log(monsters[0]); //프로그래밍에선 시작순번은 0
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        int[] monsterLevel = new int[3]; //[]에는 배열의 크기
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);


        //리스트: 기능이 추가된 가변형 그룹형 변수
        List<string> items = new List<string>(); //<>에는 자료형
        items.Add("생명물약30");
        items.Add("마나물약30");

        //배열과는 다른게 데이터 삭제 가능(0이 사라지면 1이 0번째가 된다)
        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);



        //3. 연산자: 상수, 변수값을 연산해주는 기호
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level= exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        //나머지(%)는 몫이 아닌 나머지를 출력
        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레젤까지 남은 경험치는?");
        Debug.Log(nextExp);


        //문자열에 관한 연산자
        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);


        //비교 연산자(>초과, <미만, >=이상, <=이하)
        int fullLevel = 99;
        isFullLevel = level == fullLevel; //같음을 비교할 땐 ==
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);


        //논리연결연산자(&&): 두 값이 모두 true일때만 true
        int health = 30;
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;

        //OR(||): 두 값 중에서 하나만 true면 true
        bool isBadCondition = health <= 50 || mana <= 20;

        //'? A : B': true 일 때 A, false일 때 B 출력
        string condition = isBadCondition ? "나쁨" : "좋은";
        Debug.Log("용사의 상태는 나쁩니까?" + isBadCondition);



        //4. 키워드: 프로그래밍 언어를 구성하는 특별한 단어(변수이름, 값으로도 사용불가)
        //int float string bool new List
        //int float = 1 (X)
        //string name = List (X)



        //5. 조건문
        //if문: (bool 형식으로)조건이 true일 때, 로직 실행.
        if (condition == "나쁨") 
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else //앞의 if가 실행 안될 때 실행
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }
        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }


        //switch, case: 변수값에 따라 로직 실행
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            //default: 모든 case 통과 후 실행
            default:
                Debug.Log("??? 몬스터가 출현!");
                break;
        }



        //6. 반복문
        //while: 조건이 true일 때, 로직 반복 실행
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다." + health);
            else
                Debug.Log("사망하셨습니다.");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break; //break는 빠져나와라는 명령 키워드
            }
        }


        //for: 변수를 연산하면서 로직 반복 실행
        //괄호 안에는 (연산된 변수 ; 조건 ; 연산)
        for (int count=0 ; count<10 ; count++) 
        {
            health++;
            Debug.Log("붕대로 치료중..." + health);
        }

        //for문의 강점은 그룹형 변수와의 조합
        //그룹형변수 길이: length(배열), count(리스트)
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]); //변수를 번지수로 사용
        }


        //foreach: for의 그룹형변수 탐색 특화(직접 그룹형변수 안에 있는 아이템을 하나씩 끄집냄)
        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        //health = Heal(health); 이거는 1번째 함수 적용
        Heal();

        //몬스터 3마리가 배열에 담겨있으니 for문 사용하기
        for (int index = 0 ; index < monsters.Length ; index++)
        {
            Debug.Log("용사는" + monsters[index] + "에게" +
                Battle(monsterLevel[index]));
        }



        //8. 클래스: 하나의 사물(오브젝트)와 대응하는 로직(1개의 class, 1개의 파일)
        //class: 클래스 선언에 사용(Actor 문서 참고)
        //Actor player = new Actor();
        Player player = new Player();
        //클래스를 변수로 만듦. 이를 인스턴스: 정의된 클래스를 변수 초기화로 실체화
        //변수를 선언할 때 타입을 쓰는 것 대신 클래스 이름 써주기
        //new(선언한정자): 기본 클래스에서 상속된 멤버를 명시적으로 숨김
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.move());

        //그렇담 맨 위에 있는 인스턴스 한 문장에 ': MonoBehaviour'는 무엇?
        //우리가 만든 Class Actor은 용상일 수도 몬스터일 수도 있다.
        //우리가 Actor라는 클래스로 또다른 클래스를 만들 수가 있다.
        //Player 파일처럼 만들고 위 223의 Actor클래스 대신 Player클래스로 바꿔도 문제 없음
        //파일처럼 ': Actor'을 사용함으로써 Actor 클래스 내에 있는 멤버 변수와 함수를 이 Player클래스가 물려받아서 사용할 수 있다.
        //상속관계: Actor클래스는 부모class가 되고, Player클래스는 자식class가 된다.
        //자식 클래스는 부모 클래스에 있는 모든 멤버 변수와 함수를 사용할 수도 있으면서도
        //자기자신의 새로운 멤버 변수와 함수도 추가로 사용가능하다
        //결론은 ': MonoBehaviour'를 통해 우리가 프로그래밍한 이곳이 바로 유니티 클래스를 상속한 클래스다라는 의미
    }

    //7. 함수(메소드): 기능을 편리하게 사용하도록 구성된 영역
    int Heal(int currentHealth) //괄호안에는 매개변수가 들어감. 실제변수이름과 같을필요X
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다." + currentHealth);
        return currentHealth;  //return: 함수가 값을 반환할 때 사용
    }

    //값을 받고 반환할 필요 없이 사용하기만 해도 힐을 받는 고정구조 함수
    void Heal() //void: 반환 데이터가 없는 함수 타입
    {
        health += 10; 
        //Heal함수의 입장에서는 start함수 안에 있는 health가 안 보임
        //이는 지역변수: 함수 안에서 선언된 변수(다른함수에 접근불가)
        //따라서 start 함수 위에 전역변수 선언
        Debug.Log("힐을 받았습니다." + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

        return result;
    }
}
