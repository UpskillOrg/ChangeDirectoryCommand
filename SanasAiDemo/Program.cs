/*Write a function to implement the change directory command (cd).The function will take two arguments:  - cwd   The current working directory  - cd    The directory to change intoThe function will return the fully qualified resulting path.Important points- There is no file system, so no need to verify if paths exist- There are no nulls- There are no multiple / in a row (e.g. ///)- cwd always starts from the root and is fully qualifiedExamples-------------------------------------------- cwd ------ cd ------------- result -----  /          baz              /baz-  /foo       bar              /foo/bar-  /foo/bar   ../../../../..   /-  /x/y       /p/q             /p/q-  /x/y       /p/../q          /q-  /x/y       ./p/../a/./b     /x/y/a/b-  /foo/bar   ../x/./../y      /foo/y------------------------------------------*/

static string GetFullPath(string currentPath, string navPath)
{    
    string[] currentParts = currentPath.Split('/');
    string[] navParts = navPath.Split("/");

    var partStack = new Stack<string>();

    foreach (var part in currentParts)
    {
        if(!string.IsNullOrEmpty(part)) 
        { 
            partStack.Push(part); 
        }               
    }

    foreach (var part in navParts)
    {
        if(part== ".")
        {
            continue;
        } 
        else if(part== "..")
        {
            if(partStack.Count > 0)
            {
                partStack.Pop();
            }            
        }
        else if(part == "")
        {
            partStack.Clear();
        }
        else
        {
            partStack.Push(part);
        }
    }

    var partsList = partStack.ToList();
    partsList.Reverse();

    return "/" + String.Join("/", partsList);
}

Console.WriteLine(GetFullPath("/", "baz"));
Console.WriteLine(GetFullPath("/foo", "bar"));
Console.WriteLine(GetFullPath("/foo/bar", "../../../../.."));
Console.WriteLine(GetFullPath("/x/y", "./p/../a/./b"));
Console.WriteLine(GetFullPath("/x/y", "/p/../q"));
Console.WriteLine(GetFullPath("/p/q", "/p/q"));
























































