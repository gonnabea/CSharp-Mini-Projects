using System.Collections;
using System.Collections.Generic;
using UnityEngine; // MonoBehaviour�� ��� �ִ� ����ü
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update: ������ ������ �� ���� 1ȸ �����
    void Start()
    {
        
    }

    // Update is called once per frame: �� �����Ӹ��� �ѹ� ȣ���
    void Update()
    {

        if (Input.GetKey(KeyCode.W)){
            this.transform.position = this.transform.position + new Vector3(0, 0, 1);
        }
    }
}
