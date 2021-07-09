using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalLoop : MonoBehaviour
{
    public void Coditional()
    {
        // if�� else
        if (true) // true or false
        {
            Debug.Log("���ǹ��� ���� ��� ����");
        }
        else
        {
            Debug.Log("���ǹ��� ���� �ƴ� ��� ����");
        }

        int a = 5;
        if(a <= 3)
        {
            Debug.Log("a�� 3�����϶� ����");
        }
        else if(a >= 4){
            Debug.Log("a�� 3���ϰ� �ƴϸ鼭 4�̻��� �� ����");
        }
        else
        {
            Debug.Log("a�� 3���ϰ� �ƴϸ鼭 4 �̻��� �ƴ� �� ����");
        }

        // switch
        // ������ ��찡 �������� ��� �ξ� ������
        // �ַ� �Լ��� Enum�� �Բ� ���
        switch (a)
        {
            case 1: Debug.Log("Case 1"); break;
            case 2: Debug.Log("Case 2"); break;
            case 3: // ������ ���� �б�� �Ѿ
            case 4: Debug.Log("Case 3 or 4"); break;
            case 5: Debug.Log("Case 5"); break;
            default: Debug.Log("Case Default"); break;
        }
    }

    public void ForLoop()
    {

    }

    public void WhileLoop()
    {

    }

    public void ForeachLoop()
    {
        List<int> list = new List<int>();
        for(int i=0; i<10; i++)
        {
            list.Add(i); // 0���� 9������ ���� ����Ʈ�� ����
        }

        // �ݺ� ������ �÷����� ��� �ݺ�
        foreach(int j in list)
        {
            Debug.Log("Foreach: " + j);
        }
    }
}
