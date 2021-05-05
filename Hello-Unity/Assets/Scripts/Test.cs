using System.Collections;
using System.Collections.Generic;
using UnityEngine; // MonoBehaviour를 담고 있는 집합체
using UnityEngine.UI; // KeyCode 사용 위함


public class Test : MonoBehaviour
{
    [SerializeField] // private으로 해도 inspect창에 띄우는 방법
    private GameObject go_camera;

    Vector3 rotation;

    // Start is called before the first frame update: 게임을 시작할 때 최초 1회 실행됨
    void Start()
    {
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame: 메 프레임마다 한번 호출됨, 60fps
    void Update()
    {
        

        // 회전
        if (Input.GetKey(KeyCode.W)){
            // deltaTIme은 대략 1 / 60의 값이 담김, 시스템마다 frame호출 수가 달라서 이렇게 조치
            // this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime; 

            // this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);

            rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);
            
            // 참고
            // 짐벌락이란?
            // Euler에서, 한 축을 90도로 지정했을 때, 다른 축이 해당 축과 같은 방향으로 적용될 때
            // 이걸 막기 위해서 쿼터니온(Quaternion) 사용

            Debug.Log(transform.eulerAngles);

        }
        // 크기 조절
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;
        }

        // 카메라 시점 바라보기
        if (Input.GetKey(KeyCode.X))
        {
            this.transform.LookAt(go_camera.transform.position);
        }

        // 공전시키기
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
