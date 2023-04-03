using UnityEngine;
using System;
public class CastingStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        short s = 0;
        float f;

        //암시적 형변환
        // 대부분 값이 잘리거나 반올림되지 않고 맞출 수 있을 때 암시적 형변환가능
        i = s;
        f = i;

        //상속받은 부모 클래스, 인터페이스로 암시적 변환 항상가능
        Animal ani = new Mammal();

        //명시적 형변환
        //자신보다 작은 타입인 타입으로 형변환
        s = (short)i;
        i = (int)f;

        //그냥은 안되는 상속관계의 형변환
        Mammal ma = (Mammal)ani;

        //상속관계가 없으면 명시적 형변환도 불가
        //Mammal ma2 = (Mammal)new CastingStudy();

        //함수를 통한 형변환
        string str = i.ToString();
        str = "문자열";
        try
        {

            i = int.Parse(str);
        }
        catch (DivideByZeroException e)
        {
            Debug.LogError("발생한 에러는 " + e);
        }
        catch (FormatException e) // 변환 하려는 형식이 맞지않을 때 
        {
            Debug.LogError("발생한 에러는 " + e);
        }
        catch (NullReferenceException e)
        {
            Debug.LogError("발생한 에러는 " + e);
        }
        catch (InvalidCastException e) //형변환 오류
        {
            Debug.LogError("발생한 에러는 " + e);
        }
        catch (Exception e)
        {
            Debug.LogError("발생한 에러는 " + e);
        }

        //is, as 구문
        Reptile rp = ani as Reptile;  //as는 캐스팅 할떄 사용, 익셉션 없이 안전하게 캐스팅 시도, 안될시 null을 리턴
        if (rp == null) Debug.Log("rp는 null");


        if(ani is Mammal) // is는 미리 캐스팅이 되는지 확인함, ani객체가 mammal 타입으로 형변환 가능한지 체크하고 true, false 리턴
        {
            Debug.Log("ani는 mammal 타입입니다");
        }

        if(ani is Reptile)
        {
            Debug.Log("ani는 Reptile 타입입니다.");
        }
        else
        {
            Debug.Log("ani는 Reptile 타입이 아닙니다.");
        }
        Debug.Log("함수종료시 실행되는 구문입니다.");

        
        }
}


public class Animal
{ }

public class Mammal : Animal
{ }

public class Reptile : Animal
{ }