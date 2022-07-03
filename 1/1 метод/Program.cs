//вид 1
void Method1()
{
    Console.WriteLine("avtor mail");
}
Method1();

// вид2

void Method2(string msg, int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
   
}
//Method2(" text", count: 4);
Method2(count: 4,msg: "new text");

//вид 3 возврашать

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// вид 4 метода 
//string Method4(int count,string text)
{
//    int i = 0;
//    string result=String.Empty;
//    while(i<count)
//    {
//        result+=text;
//        i++;
//    }
//    return result;
//}
//string result = Method4(10,"asdf");
//Console.WriteLine(result);


//пример
string MethodA(int count,string text)
{
    int i = 0;
    string result=String.Empty;
    for(int i=0;i< count; i++)
    {
        result+=text;
    }
    return result;
}
string result = MethodA(10,"z");
Console.WriteLine(result);
