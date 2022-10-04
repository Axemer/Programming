// LAB_1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

using namespace std;

void SortAsc(double *arr, int n)
{
    double temp;
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
        {
            if (arr[i] <= arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
}

double GetPower(double base, int exponent) 
{
    double conclusion = base;
    for (int i = 1; i < exponent; i++)
    {
        conclusion = conclusion * base;
    }
    return conclusion;
}

void DemoGetPower(double base, int exponent) 
{
    double result = GetPower(base, exponent);
    cout << base << " ^ " << exponent << " = " << result << endl;
}

void RoundToTens(int& value) 
{
    int base = value;

    double d = base + 0.0;
    d = d / 10;

    int f = base / 10;
    if (d - f <= 0.5)
    {
        base = f * 10;
    }
    else
    {
        base = (f + 1) * 10;
    }

    cout << "For " << value << " rounded value is " << base << endl;
}

void Breakpoints()
{
    double add = 1.0;
    double sum = 0.0;
    for (int i = 0; i < 10; i++)
    {
        sum += add * i;
        add *= 1.1;
    }
    cout << "Total sum is " << sum << endl;

	// 1.1.1.1
// sum is 0
// sum is 1.1
// sum is 3.52
// sum is 7.513
// sum is 13.3694
// sum is 21.422
// sum is 32.0513
// sum is 45.6923
// sum is 62.841
// sum is 84.0626
}

void Breakpoints2()
{
	double add = 1.0;
	double sum = 0.0;
	for (int i = 0; i < 1000; i++)
	{
		sum += add * i; 
        // sum on 777 is 3.2624579394327844
		if (i % 3 == 0)
		{
			add *= 1.1;
		}
		else
		{
			add /= 3.0;
		}
	}
	cout << "Total sum is " << sum << endl;
}

void Massive()
{
    double array[10] {1.0, 7.0, 3.0, 9.0, 10.0, 8.83, 4.04, 6.06, 5.91, 0.0 };
    
    cout << "source array: " << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << array[i] << endl;
    }

    SortAsc(array, 10);
    cout << "sorted array: " << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << array[i] << endl;
    }

}

void Massive2()
{
    const int n = 12;
    double array[n] {12.0, 21.5, 119.2, -80.7, 300.0, 75.5, 81.2, 8.1, 47.3, 31.2, 85.3, 100.1};

    cout << "source array: " << endl;
    for (int i = 0; i < n; i++)
    {
        cout << array[i] << endl;
    }

    int input;
    int count = 0;

    cout << "Enter searching value: ";
    cin >> input;

    for (int i = 0; i < n; i++) 
    {
        if (array[i] > input)
            count++;
    }
    cout << "Elements of array more than " << input << " is: " << count;
}

void Massive3() 
{
    const int n = 8;
    char array[n];

    cout << "Enter array of 8 chars\n";
    for (int i = 0; i < n; i++)
    {
        cout << "a[" << i << "]: ";
        cin >> array[i];
    }

    cout << "Your array is: \n";
    for (int i = 0; i < n; i++) 
    {
        cout << array[i] << " ";
    }
    
    cout << endl << "All letters in your array: \n";
    for (int i = 0; i < n; i++) 
    {
        if (array[i] >= 'A' && array[i] <= 'Z' || array[i] >= 'a' && array[i] <= 'z')
            cout << array[i] << " ";
    }
}

void Function() 
{
    cout << " 2.0 ^ 5 = " << GetPower(2.0, 5) << endl;
    cout << " 3.0 ^ 4 = " << GetPower(3.0, 4) << endl;
    cout << "-2.0 ^ 5 = " << GetPower(-2.0, 5) << endl;
}

void Function2()
{
    DemoGetPower(2.0, 5);
    DemoGetPower(3.0, 4);
    DemoGetPower(-2.0, 5);
}

void Function3() 
{
    int a = 14;
    RoundToTens(a);
    a = 191;
    RoundToTens(a);
    a = 27;
    RoundToTens(a);
}

void AddressesAndPointers() 
{
    int a = 5;
    int b = 4;
    cout << "Address of a: " << &a << endl;
    cout << "Address of b: " << &b << endl;
    double c = 13.5;
    cout << "Address of c: " << &c << endl;
    bool d = true;
    cout << "Address of d: " << &d << endl;
}

void AddressesAndPointers2()
{
    int a[10] = { 1, 2, 7, -1, 5, 3, -1, 7, 1, 6 };
    cout << "Size of int type: " << sizeof(int) << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << "Address of a[" << i << "]: " << &a[i] << endl;
    }
    cout << endl;
    cout << "Size of double type: " << sizeof(double) << endl;
    double b[10] = { 1.0, 2.0, 7.0, -1.0, 5.0, 3.5, -1.8, 7.2, 1.9, 6.2
    };
    for (int i = 0; i < 10; i++)
    {
        cout << "Address of b[" << i << "]: " << &b[i] << endl;
    }
}

void AddressesAndPointers3()
{
    int a = 5;
    int& b = a;
    cout << "Address of a: " << &a << endl;
    cout << "Address of b: " << &b << endl;
    cout << endl;
    b = 7;
    cout << "Value of a: " << a << endl;
}

void Foo(double a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;
    a = 15.0;
    cout << "New value of a in Foo(): " << a << endl;
}

void AddressesAndPointers4()
{
    double a = 5.0;
    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;
    Foo(a);
    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}

void Foo2(double& a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;
    a = 15.0;
    cout << "New value of a in Foo(): " << a << endl;
}

void AddressesAndPointers5()
{
    double a = 5.0;
    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;
    Foo2(a);
    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}

void AddressesAndPointers6()
{
    int a = 5;
    int* pointer = &a;
    cout << "Address of a: " << &a << endl;
    cout << "Address in pointer: " << pointer << endl;
    cout << "Address of pointer: " << &pointer << endl;
    cout << endl;
    *pointer = 7;
    cout << "Value in a: " << a << endl;
    cout << "Value by pointer address: " << *pointer << endl;
}

void AddressesAndPointers7()
{
    cout << "Pointers declared like this: ( type *name = value; ) \n" <<
            "Dereferencig pointer like this: ( *name ) \n"
            "Multiplication done like this: ( name * name ) \n";
}

void Foo3(double* a)
{
    cout << "Address in pointer: " << a << endl;
    cout << "Address of pointer: " << &a << endl;
    cout << "Value in pointer address: " << *a << endl;
    *a = 15.0;
    cout << "New value in pointer address: " << *a << endl;
}

void AddressesAndPointers8()
{
    double value = 5.0;
    double* pointer = &value;
    cout << "Address of value in main(): " << &value << endl;
    cout << "Address in pointer in main(): " << pointer << endl;
    cout << "Address of pointer in main(): " << &pointer << endl;
    cout << "Value of a in main(): " << value << endl;
    cout << endl;
    Foo3(pointer);
    cout << endl;
    cout << "Value of a in main(): " << value << endl;
}

void DynamicRAM()
{
    int size = 8;
    double* array = new double[size] {1.0, 15.0, -8.2, -3.5, 12.6, 38.4, -0.5, 4.5};

    cout << "Double array: " << endl;
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }

    delete array;
}

void DynamicRAM2()
{
    int size = 8;
    bool* array = new bool[size] {true, false, true, true, false, true, false, false};
    cout << "Bool array: " << endl;
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }

    delete array;
}

void DynamicRAM3()
{
    int size = 0;
    cout << "Enter char array size: ";
    cin >> size;
    char* array = new char[size];

    cout << "Enter array of 8 chars\n";
    for (int i = 0; i < size; i++)
    {
        cout << "a[" << i << "]: ";
        cin >> array[i];
    }

    cout << "Your char array is: \n";
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }

    delete array;
}

void DynamicRAM4()
{
    int size = 10;
    double* array = new double[size] {1.0, 15.0, -8.2, -3.5, 12.6, 38.4, -0.5, 4.5, 16.7, 4.5};

    cout << "Array of double: " << endl;
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }
    SortAsc(array, size);
    cout << "Sorted array of double: " << endl;
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }
    delete array;
}

void DynamicRAM5()
{
    int size = 10;
    int* array = new int[size] {1, 15, -8, -3, 12, 38, 0, 4, 16, 4};

    cout << "source array: " << endl;
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }

    cout << endl;
    int input;
    cout << "Enter searching value: ";
    cin >> input;
    cout << endl;

    for (int i = 0; i < size; i++)
    {
        if (array[i] == input)
        {
            cout << "Index of searching value  " << input << " is: " << i;
            break;
        }
    }
}

void DynamicRAM6()
{
    int size = 16;
    char* array = new char[size] 
    {'a', '5', 'm', 'i', '%', '!', 'j', '5', '>', 'f', '0', '@', ';', '0', '0'};

    cout << "Char array is: \n";
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }

    cout << endl << "All letters in array: \n";
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 'A' && array[i] <= 'Z' || array[i] >= 'a' && array[i] <= 'z')
            cout << array[i] << " ";
    }
}

int* MakeRandomArray(int arraySize)
{
    int* array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = (rand() % 100);
    }
    return array;
}

void DynamicRAM7()
{
    int arraySize = 5;
    int* array = MakeRandomArray(arraySize);

    cout << "Random array of" << arraySize << ": \n";
    for (int i = 0; i < arraySize; i++)
    {
        cout << array[i] << " ";
    }
    delete array;
    cout << endl;

    arraySize = 8;
    array = MakeRandomArray(arraySize);

    cout << "Random array of" << arraySize << ": \n";
    for (int i = 0; i < arraySize; i++)
    {
        cout << array[i] << " ";
    }
    delete array;
    cout << endl;

    arraySize = 13;
    array = MakeRandomArray(arraySize);

    cout << "Random array of" << arraySize << ": \n";
    for (int i = 0; i < arraySize; i++)
    {
        cout << array[i] << " ";
    }
    delete array;
    cout << endl;
}

int* ReadArray(int count)
{
    int* values = new int[count];
    cout << "Enter values: \n";
    for (int i = 0; i < count; i++)
    {
        cin >> values[i];
    }
    return values;
}
int CountPositiveValues(int* values, int count)
{
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (values[i] > 0)
        {
            result++;
        }
    }
    return result;
}
void DynamicRAM8Leak()
{
    int count = 15;
    int* values = ReadArray(count);
    cout << "Count is: " << CountPositiveValues(values, count) << endl;

    // сдесь мы забыли удалить первый массив значит утечка тут, фикс просто:
    delete[] values;
    // по идее все

    count = 20;
    values = ReadArray(count);
    cout << "Count is: " << CountPositiveValues(values, count) << endl;

    delete[] values;
}


int main()
{
    std::cout << "Choose your destiny\n";
    int input;

    cout << "1. 1.1.1.1 \n";
    cout << "2. 1.1.1.2 \n";

    cout << "3. 1.1.2.1 \n";
    cout << "4. 1.1.2.2 \n";
    cout << "5. 1.1.2.3 \n";

    cout << "6. 1.1.3.2 \n";
    cout << "7. 1.1.3.3 \n";
    cout << "8. 1.1.3.4 \n";

    cout << "9.  1.1.4.1 \n";
    cout << "10. 1.1.4.2 \n";
    cout << "11. 1.1.4.3 \n";
    cout << "12. 1.1.4.4 \n";
    cout << "13. 1.1.4.5 \n";
    cout << "14. 1.1.4.6 \n";
    cout << "15. 1.1.4.7 \n";
    cout << "16. 1.1.4.8 \n";

    cout << "17. 1.1.5.1 \n";
    cout << "18. 1.1.5.2 \n";
    cout << "19. 1.1.5.3 \n";
    cout << "20. 1.1.5.4 \n";
    cout << "21. 1.1.5.5 \n";
    cout << "22. 1.1.5.6 \n";
    cout << "23. 1.1.5.7 \n";
    cout << "24. 1.1.5.8 \n";




    cout << "999. Exit  \n";
    cout << "Selection: ";
    cin >> input;
    switch (input) {
    case 1:
        printf("\033c"); 
        Breakpoints();
        break;
    case 2:
        printf("\033c"); 
        Breakpoints2();
        break;
    case 3:
        printf("\033c"); 
        Massive();
        break;
    case 4:
        printf("\033c"); 
        Massive2();
        break;
    case 5:
        printf("\033c");
        Massive3();
        break;
    case 6:
        printf("\033c");
        Function();
        break;
    case 7:
        printf("\033c");
        Function2();
        break;
    case 8:
        printf("\033c");
        Function3();
        break;
    case 9:
        printf("\033c");
        AddressesAndPointers();
        break;
    case 10:
        printf("\033c");
        AddressesAndPointers2();
        break;
    case 11:
        printf("\033c");
        AddressesAndPointers3();
        break;
    case 12:
        printf("\033c");
        AddressesAndPointers4();
        break;
    case 13:
        printf("\033c");
        AddressesAndPointers5();
        break;
    case 14:
        printf("\033c");
        AddressesAndPointers6();
        break;
    case 15:
        printf("\033c");
        AddressesAndPointers7();
        break;
    case 16:
        printf("\033c");
        AddressesAndPointers8();
        break;
    case 17:
        printf("\033c");
        DynamicRAM();
        break;
    case 18:
        printf("\033c");
        DynamicRAM2();
        break;
    case 19:
        printf("\033c");
        DynamicRAM3();
        break;
    case 20:
        printf("\033c");
        DynamicRAM4();
        break;
    case 21:
        printf("\033c");
        DynamicRAM5();
        break;
    case 22:
        printf("\033c");
        DynamicRAM6();
        break;
    case 23:
        printf("\033c");
        DynamicRAM7();
        break;
    case 24:
        printf("\033c");
        DynamicRAM8Leak();
        break;

    case 0:
        printf("\033c"); 
        cout << "add me \n";
        break;
    case 999:
        printf("\033c"); 
        cout << "Thank you for using!\n";
        break;
    default:
        printf("\033c"); // Resets terminal VT100 style
        cout << "Error, bad input, quitting\n";
        break;
    }
}


// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
