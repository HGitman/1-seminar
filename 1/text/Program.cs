string text = "Печально я гляжу на наше поколенье!"
            + "Его грядущее — иль пусто, иль темно,"
            + "Меж тем, под бременем познанья и сомненья,"
            + "В бездействии состарится оно.";
// string s = "aasddf "
             //012345
//s[3] // s

string Replace(string text, char oldValue,char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result =result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text,' ','|');
Console.WriteLine(newText);