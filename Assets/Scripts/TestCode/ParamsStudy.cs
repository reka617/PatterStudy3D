using UnityEngine;

public class ParamsStudy : MonoBehaviour
{
    private void Start()
    {
        
        myFunc(2);
        Debug.Log(myIntFunc());
        myParamsFunc(9, 7, 12, 14, 15, 13, 28);//데이터를 전부 받음

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
        //j = 10; // 입력받은 인자값 수정 불가
    }

    void outInt(out int j)//ref와 비슷하게 참조 전달하는데 반드시 할당해줘야함
    {
        j = 15; //리턴과 동일
    }

    void myParamsFunc(params int[] i) // params라는 키워드를 통해 특정타입을 배열로 전달받을 수 있다.
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
