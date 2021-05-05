using System.Collections;
using System.Collections.Generic;
using UnityEngine; // MonoBehaviour�� ��� �ִ� ����ü
using UnityEngine.UI; // KeyCode ��� ����


public class Test : MonoBehaviour
{
    [SerializeField] // private���� �ص� inspectâ�� ���� ���
    private GameObject go_camera;

    Vector3 rotation;

    // Start is called before the first frame update: ������ ������ �� ���� 1ȸ �����
    void Start()
    {
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame: �� �����Ӹ��� �ѹ� ȣ���, 60fps
    void Update()
    {
        

        // ȸ��
        if (Input.GetKey(KeyCode.W)){
            // deltaTIme�� �뷫 1 / 60�� ���� ���, �ý��۸��� frameȣ�� ���� �޶� �̷��� ��ġ
            // this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime; 

            // this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);

            rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);
            
            // ����
            // �������̶�?
            // Euler����, �� ���� 90���� �������� ��, �ٸ� ���� �ش� ��� ���� �������� ����� ��
            // �̰� ���� ���ؼ� ���ʹϿ�(Quaternion) ���

            Debug.Log(transform.eulerAngles);

        }
        // ũ�� ����
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;
        }

        // ī�޶� ���� �ٶ󺸱�
        if (Input.GetKey(KeyCode.X))
        {
            this.transform.LookAt(go_camera.transform.position);
        }

        // ������Ű��
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
