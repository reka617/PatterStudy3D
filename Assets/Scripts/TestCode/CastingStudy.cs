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

        //�Ͻ��� ����ȯ
        // ��κ� ���� �߸��ų� �ݿø����� �ʰ� ���� �� ���� �� �Ͻ��� ����ȯ����
        i = s;
        f = i;

        //��ӹ��� �θ� Ŭ����, �������̽��� �Ͻ��� ��ȯ �׻󰡴�
        Animal ani = new Mammal();

        //����� ����ȯ
        //�ڽź��� ���� Ÿ���� Ÿ������ ����ȯ
        s = (short)i;
        i = (int)f;

        //�׳��� �ȵǴ� ��Ӱ����� ����ȯ
        Mammal ma = (Mammal)ani;

        //��Ӱ��谡 ������ ����� ����ȯ�� �Ұ�
        //Mammal ma2 = (Mammal)new CastingStudy();

        //�Լ��� ���� ����ȯ
        string str = i.ToString();
        str = "���ڿ�";
        try
        {

            i = int.Parse(str);
        }
        catch (DivideByZeroException e)
        {
            Debug.LogError("�߻��� ������ " + e);
        }
        catch (FormatException e) // ��ȯ �Ϸ��� ������ �������� �� 
        {
            Debug.LogError("�߻��� ������ " + e);
        }
        catch (NullReferenceException e)
        {
            Debug.LogError("�߻��� ������ " + e);
        }
        catch (InvalidCastException e) //����ȯ ����
        {
            Debug.LogError("�߻��� ������ " + e);
        }
        catch (Exception e)
        {
            Debug.LogError("�߻��� ������ " + e);
        }

        //is, as ����
        Reptile rp = ani as Reptile;  //as�� ĳ���� �ҋ� ���, �ͼ��� ���� �����ϰ� ĳ���� �õ�, �ȵɽ� null�� ����
        if (rp == null) Debug.Log("rp�� null");


        if(ani is Mammal) // is�� �̸� ĳ������ �Ǵ��� Ȯ����, ani��ü�� mammal Ÿ������ ����ȯ �������� üũ�ϰ� true, false ����
        {
            Debug.Log("ani�� mammal Ÿ���Դϴ�");
        }

        if(ani is Reptile)
        {
            Debug.Log("ani�� Reptile Ÿ���Դϴ�.");
        }
        else
        {
            Debug.Log("ani�� Reptile Ÿ���� �ƴմϴ�.");
        }
        Debug.Log("�Լ������ ����Ǵ� �����Դϴ�.");

        
        }
}


public class Animal
{ }

public class Mammal : Animal
{ }

public class Reptile : Animal
{ }