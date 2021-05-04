using System.Collections;
using System.Collections.Generic;
using UnityEngine; // MonoBehaviour를 담고 있는 집합체
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update: 게임을 시작할 때 최초 1회 실행됨
    void Start()
    {
        
    }

    // Update is called once per frame: 메 프레임마다 한번 호출됨
    void Update()
    {

        if (Input.GetKey(KeyCode.W)){
            this.transform.position = this.transform.position + new Vector3(0, 0, 1);
        }
    }
}
