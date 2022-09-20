using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //1.초기화 영역: 유니티 생명주기에서 가장 첫번째로 시작
    void Awake() //게임 오브젝트 생성할 때, 최초 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable() //게임 오브젝트가 활성화 되었을 때(최초실행이 아닌 켜고 끌 때마다 실행)
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start() //업데이트 시작 직전, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }


    //2.물리연산 영역
    void FixedUpdate()  //유니티 엔진이 물리연산을 하기 전에 실행되는 업데이트 함수
                        //특징: (1s당 50회 호출)고정된 실행 주기로 CPU를 많이 사용.(사양과 관계없이)
    {
        Debug.Log("이동~");
    }


    //3.게임로직 영역
    void Update()   //물리연산을 제외한 나머지 주기적으로 변하는 로직을 넣을때 사용
                    //(60프레임)환경(사양)에 따라서 실행주기가 떨어질 있다.
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() //모든 업데이트 끝난 후 노출되는 함수(후처리)
    {
        Debug.Log("경험치 획득.");
    }


    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }
    //script 체크 해제하면 뜸 (다시 체크시 재실행)

    //해체 영역
    void OnDestroy() //게임 오브젝트가 삭제될 때 (무언갈 남기고 실행됨)
    {
        Debug.Log("플레이어 데이터가 해제하였습니다.");
    }


    //게임오브젝트는 삭제하지 않고 켜고 끌수 있다.
    //활성화: 초기화와 물리 영역 사이(스타트보단 빠르게)
    //비활성화: 모든 업데이트가 다 끝난 후 비활성화하거나 삭제할 때





    //키보드 마우스로 이동시켜보자!
    void Update()
    {
        //input: 게임 내 입력을 관리하는 클래스

        //anykeydown: 아무 입력을 최초로 받을 때 true
        //anykey: 아무 입력을 받으면 true

        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        //각 입력 함수는 3가지 행동으로 구분: down, stay, up


        //GetKey: 키보드 버튼 입력을 받으면 true (매개변수: KeyCode.00)

        if (Input.GetKeyDown(KeyCode.Return)) //Return: 엔터, Escape: esc
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");


        //GetMouse: 마우스 버튼 입력을 받으면 true

        if (Input.GetMouseButtonDown(0)) //매개변수: 0(왼쪽), 1(오른쪽)
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");


        //세밀한 키는 Edit>Project Settings>input manager에서 확인(자동설정되어있음)
        //기존키 변경 가능, 사이즈를 키우면 GetButton 매개변수 새로추가 가능

        //GetBuutton: input 버튼 입력을 받으면 true
        //매개변수: input manager 문자 (대소문자 구분해야함)
        //물리적인 디바이스 구애받지 않고 같은 이름으로 여러가지 디바이스를 동시에 설정할 수 있다.
        //모바일도 이걸로 커버 가능

        if (Input.GetButtonDown("Fire1"))   //모을 땐 down 안씀
            Debug.Log("점프!");

        if (Input.GetButton("Fire1"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("슈퍼 점프!!");


        //횡 이동할 때
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..."
                //GetAxis: (가중치를 줄 때)수평, 수직 버튼 입력을 받으면 float값 반환
                //오브젝트는 변수 transform을 항상 가지고 있음.
                //GetAsixRaw: (가중치X) 1과 -1만 나오게끔. 동시에 누르면 0.
                + Input.GetAxisRaw("Horizontal"));
        }

        //종 이동할 때
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..."
                + Input.GetAxisRaw("Vertical"));
        }

    }




    //오브젝트 이동
    //Project창에 무슨 게임오브젝트 만들어도 Transform은 항상 포함됨(1:1관계)
    //(Class)Transform: 오브젝트 형태에 대한 기본 컴포넌트
    //오브젝트는 변수 transform을 항상 가지고 있음.(이미 초기환됨. 따로 정의X)
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),   //중간값 없으려면 GetAxisRaw
            Input.GetAxis("Vertical"), 
            0);

        //Translate: 벡터값을 현재 위치에 더하는 (이동)함수
        transform.Translate(vec);
    }

}
