// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
//["1234", "1567", "-2", "computer science"] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[]cc = {"Hello", "2", "world", ":-)"};
int count=0;
int j=0;
string s;

for(int i=0;i<cc.Length;i++) //находим длину нового массива
    {
        Metod(cc[i]);
        if (s.Length<=3) 
            {
                count++;
            }
        
    }
if (count==0)
    {
        System.Console.WriteLine("нет элементов удовлетворяющих условию задачи");
        return;
    }

      
string[]cc2=new string[count];//задаем новый массив 
for(int i=0;i<cc.Length;i++)//заполняем новый массив согласно условиям задачи
       {
        Metod(cc[i]);
        count++;
         if (s.Length<=3) 
            {
                cc2[j]=cc[i];
                j++;
            }
    }
for(int i=0;i<cc2.Length;i++)
System.Console.Write($"{cc2[i]} ");

void Metod (string a)//массив из элементов определенного элемента массива строк
    { 
        s=a;
        char[] array=s.ToArray();
        s=new String(array);
    }


