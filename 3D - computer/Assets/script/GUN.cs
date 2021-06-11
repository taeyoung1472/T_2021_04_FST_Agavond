using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUN : MonoBehaviour
{
    //총관련
    public int arr;//총의 배열값
    private string[] GunName = {"PMM", "PL15", "Revolver", "MP7", "AK74", "SA58", "SVD", "M24", "M249"};//총의 이름
    [SerializeField]
    private float[] RPM = { 0.2f, 0.15f, 1f, 0.067f, 0.1f, 0.12f, 0.5f, 2f, 0.075f };//발사간격
    public Animator[] animator;
    public Animator[] animator1;
    public int curammo;//현재 총알
    [SerializeField]
    private int[] magammo = { 7, 15, 6, 30, 30, 20, 10, 5, 99 };//탄창당 총알
    [SerializeField]
    private float[] ReloadTime = { 3, 1, 1, 1, 1, 1, 1, 1, 1};//총의 장전시간
    //public float ReloadTime;//예비 장전 시간
    public bool Fire;//총을 쏠지 안쏠지
    public GameObject[] Bullet;//총알
    public Transform[] FirePos;//총알이 나가는 위치
    public bool istick;//총알을 다써서 빈 소리가 난지 판단
    //총 관련 UI
    public Text HUD;//총 탄창 현황을 나타냄
    public Text UI_GunName;//총의 이름을 보여줌
    //총 관련 오디오
    public AudioSource[] arrayAudio;//총에 쓰이는 여러 소리소스
    [SerializeField]
    private Camera camera;//카메라
    [SerializeField]
    private float[] reboundY = { -1f, -1f, -1f, -1f, -1f, -1f, -1f, -1f, -1f };//세로반동
    [SerializeField]
    private float[] reboundX = { 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f };//가로반동
    public float rebound_totalZ;//가로반동 렌덤값 저장소
    public TouchRotation touchRotation;//회전 관련 스크립트
    public float zoom;//줌을 풀시의 포브값을 저장하는 변수
    [SerializeField]
    private float[] zoomSize = { 2f, 2f, 2f, 2f, 2f, 2f, 2f, 2f, 2f };//줌할시 적용되는 배율
    //[SerializeField]
    //public GameObject[] muzzelFlash;
    public Button btnZoom;//줌버튼
    private bool isZoom = false;//줌 판단 변수
    private bool isFire = true;
    public GameObject[] gunObject;
    private void Awake()//사운드를 받아옴
    {
        arrayAudio = GameObject.Find("Sound").GetComponents<AudioSource>();
    }
    void Start()//줌버튼의 온클릭을 스크립트에 넣기,장전하기,쏘기 코루틴 실행
    {
        //muzzelFlash[arr].SetActive(false);
        btnZoom.onClick.AddListener(Zoom);
        StartCoroutine(Reload());
        StartCoroutine(Shoot());
        StartCoroutine(GunUse());
    }
    public IEnumerator GunUse()
    {
        yield return new WaitForSeconds(1f);
        gunObject[arr].SetActive(true);
    }
    public IEnumerator Reload()//장전소리 > 장전시간 기달리기 > 탄약 채우기 > 탄약 UI정보 업데이트하기
    {
        isFire = false;
        arrayAudio[2].Play();
        if (isZoom == true)
            animator1[arr].Play("ZoomOut");
        animator[arr].Play("Reload 0");
        yield return new WaitForSeconds(ReloadTime[arr]);
        curammo = magammo[arr];
        HUD.text = string.Format("{0} / {1}", curammo, magammo[arr]);
        if(isZoom == true)
            animator1[arr].Play("Zoom");
        isFire = true;
    }
    private IEnumerator Shoot()//무한반복 되며 FIre가 True 일시 쏨
    {
        while(true)
        {
            if (Fire == true && curammo >= 1 && isFire == true)//Fire가 True 이고 현재 총알이 1과 같거나 클시 실행
            {
                camera.fieldOfView = 65 / zoom;//포브를 넓혀 뒤로 밀리는 효과
                Instantiate(Bullet[arr], FirePos[arr].transform.position, FirePos[arr].transform.rotation);//총알을 총알 위치와 회접값에 생성
                //muzzelFlash[arr].SetActive(true);
                animator[arr].Play("Shoot");
                rebound_totalZ = Random.Range(-reboundX[arr], reboundX[arr]);//+좌우반동 -좌우반동 사이에서 랜덤값 지정하기 
                touchRotation.rebound(reboundY[arr],rebound_totalZ);//터치로테이션에 리바운드 실행
                arrayAudio[0].Play();//발사음 송출
                curammo--;//현재 총알깍기
                HUD.text = string.Format("{0} / {1}", curammo, magammo[arr]);//총알 정보업데이트
                istick = true;//총알이 아직 차있다는 뜻
                yield return new WaitForSeconds(RPM[arr]);//다음 총쏘기 판단까지 기달리기
            }
            //muzzelFlash[arr].SetActive(falswe);
            if (Fire == true && curammo == 0 && istick == true && isFire == true)//현재총알이 0개이고 tick이 true일떄 실행
            {
                istick = false;//istick 을 false로
                arrayAudio[1].Play();//tick 사운드를 실행
            }
            yield return new WaitForSeconds(0.01f);
                            camera.fieldOfView = 60 / zoom;//카메라 줌 초기화h
        }
    }
    public void pullgun(int gun)//arr값을 받는 함수
    {
        arr = gun;
    }
    public void ButtonShoot()//버튼 입력시 실행되는 함수 Fire 를 활성화
    {
            Fire = true;
    }
    public void ButtonShootStop()//버튼을 떌시 실행되는 함수 FIre를 비활성화
    {
        Fire = false;
    }
    public void Zoom()//줌 함수
    {
        if (!isZoom)
        {
            animator1[arr].Play("Zoom");
            zoom = zoomSize[arr];
        }else
        {
            animator1[arr].Play("ZoomOut");
            zoom = 1;
        }
        isZoom = !isZoom;
    }
    public void Reroad()
    {
        StartCoroutine(Reload());
    }
}
        /*ShootDelay = 0f;
        Debug.DrawRay(transform.position, transform.forward * Range, Color.yellow, 0.1f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, Range))
        {
            if (hit.transform.GetComponent<enemy>())
            {
                hit.transform.GetComponent<enemy>().hp -= damage[arr];
                arrayAudio[5].Play();
            }
            hit.transform.GetComponent<wall>().Hit_Count++;
            
        }*/