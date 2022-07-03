string MethodA(int count,string text)
{
    string result=String.Empty;
    for(int i=0;i< count; i++)
    {
        result+=text;
    }
    return result;
}
string result = MethodA(10,"z");
Console.WriteLine(result);

