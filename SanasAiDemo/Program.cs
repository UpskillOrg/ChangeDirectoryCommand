﻿/*

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























































