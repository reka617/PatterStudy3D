using UnityEngine;

public class ParamsStudy : MonoBehaviour
{
    private void Start()
    {
        
        myFunc(2);
        Debug.Log(myIntFunc());
        myParamsFunc(9, 7, 12, 14, 15, 13, 28);//�����͸� ���� ����

        int i = 5;
        valueInt(i);
        Debug.Log("Start int i :" + i);

        refInt(ref i);
        Debug.Log("Start int i : " + i);

        outInt(out i);
        Debug.Log("Start out int i : " + i);


    }

    void refInt(ref int j)
    {
        j = 10;
        Debug.Log("ref int j"+ j);
    }

    void valueInt(int j)
    {
        j = 10;
        Debug.Log("value int " + j);

    }

    void inInt(in int j)
    {
        //j = 10; // �Է¹��� ���ڰ� ���� �Ұ�
    }

    void outInt(out int j)//ref�� ����ϰ� ���� �����ϴµ� �ݵ�� �Ҵ��������
    {
        j = 15; //���ϰ� ����
    }

    void myParamsFunc(params int[] i) // params��� Ű���带 ���� Ư��Ÿ���� �迭�� ���޹��� �� �ִ�.
    {
        for(int j = 0; j< i.Length; j++) 
        {
            Debug.Log(i[j]);
        }

    }
    void myFunc(int i)
    {
        Debug.Log(i);
    }

    int myIntFunc()
    {
        return 5;
    }
    
}


public class paramsParent
{
    public virtual void pFunc(params object[] objs)
    {

    }
}

public class paramsChild : paramsParent
{
    public override void pFunc(params object[] objs)
    {
        Debug.Log("HP : " + objs[0]);
        Debug.Log("Attack : " + objs[1]);
    }
}


public class paramsChild2 : paramsParent
{
    public override void pFunc(params object[] objs)
    {
        Debug.Log("Def : " + objs[0]);
        Debug.Log("AttackRate : " + objs[1]);
    }
}
