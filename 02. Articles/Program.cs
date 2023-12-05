﻿string articleData = Console.ReadLine();
string title = articleData.Split(", ")[0];
string content = articleData.Split(", ")[1];
string author = articleData.Split(", ")[2];

Article article = new Article(title, content, author);
int countCommands = int.Parse(Console.ReadLine());
for (int i = 1; i <= countCommands; i++)
{
    string command = Console.ReadLine();
    string[] commandParts = command.Split(": ");
    string commandName = commandParts[0];
    string commandParameter = commandParts[1];

    switch (commandName)
    {
        case "Edit":
            article.Edit(commandParameter);
            break;
        case "ChangeAuthor":
            article.ChangeAuthor(commandParameter);
            break;
        case "Rename":
            article.Rename(commandParameter);
            break;
    }

}

// Принтиране на статията 
// 1. начин
// Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
// 2. начин
Console.WriteLine(article.ToString());




