using System;

//ref link:https://www.youtube.com/watch?v=k3VPCamU7V8&list=PLF932FF551E0ADD16&index=10
//ctrl+k+b -- code snippets manager
//ctrl+o -- open file
//ctrl+k+s -- surroung with: code snippets
//svm - static void main

/*------while.snippet---------------------
 * 
<?xml version="1.0" encoding="utf-8" ?>
<CodeSnippets  xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
	<CodeSnippet Format="1.0.0">
		<Header>
			<Title>while</Title>
			<Shortcut>while</Shortcut>
			<Description>Code snippet for while loop</Description>
			<Author>Microsoft Corporation</Author>
			<SnippetTypes>
				<SnippetType>Expansion</SnippetType>
				<SnippetType>SurroundsWith</SnippetType>
			</SnippetTypes>
		</Header>
		<Snippet>
			<Declarations>
				<Literal>
					<ID>expression</ID>
					<ToolTip>Expression to evaluate</ToolTip>
					<Default>true</Default>
				</Literal>
			</Declarations>
			<Code Language="csharp"><![CDATA[while ($expression$)
	{
	        $selected$ $end$
	}]]>
			</Code>
		</Snippet>
	</CodeSnippet>
</CodeSnippets>
 * 
 * -------for.snippet----------------------------
 * 
<?xml version="1.0" encoding="utf-8" ?>
<CodeSnippets  xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
	<CodeSnippet Format="1.0.0">
		<Header>
			<Title>for</Title>
			<Shortcut>for</Shortcut>
			<Description>Code snippet for 'for' loop</Description>
			<Author>Microsoft Corporation</Author>
			<SnippetTypes>
				<SnippetType>Expansion</SnippetType>
				<SnippetType>SurroundsWith</SnippetType>
			</SnippetTypes>
		</Header>
		<Snippet>
			<Declarations>
				<Literal>
					<ID>index</ID>
					<Default>i</Default>
					<ToolTip>Index</ToolTip>
				</Literal>
				<Literal>
					<ID>max</ID>
					<Default>length</Default>
					<ToolTip>Max length</ToolTip>
				</Literal>
			</Declarations>
			<Code Language="csharp"><![CDATA[for (int $index$ = 0; $index$ < $max$; $index$++)
			{
			$selected$ $end$
			}]]>
			</Code>
		</Snippet>
	</CodeSnippet>
</CodeSnippets>

 * 
 * ------svm.snippet
 * 
<?xml version="1.0" encoding="utf-8" ?>
<CodeSnippets  xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
	<CodeSnippet Format="1.0.0">
		<Header>
			<Title>svm</Title>
			<Shortcut>svm</Shortcut>
			<Description>Code snippet for 'void Main' method</Description>
			<Author>Microsoft Corporation</Author>
			<SnippetTypes>
				<SnippetType>Expansion</SnippetType>
			</SnippetTypes>
		</Header>
		<Snippet>
			<Code Language="csharp">
				<![CDATA[using System;
				
class MainClass
{
	static void Main()
	{
	$end$
	}
}]]>
			</Code>
		</Snippet>
	</CodeSnippet>
</CodeSnippets>



 * 
 */


class MainClass
{
    static void Main()
    {
        while (true)
        {
			while (true)
			{

			}
        }
        while (true)
        {
			while (true)
			{
				Console.WriteLine("What is your name?");
				string yourName = Console.ReadLine();
				Console.WriteLine(yourName);  
			}
        }



        //string[] people = new[] { "Kulpot", "Jim", "Bob" };
        //foreach (string name in people)
        //{
        //    Console.WriteLine(name);
        //}
        //for (int meIndex = people.Length - 1; meIndex >= 0; meIndex--)
        //{
        //    Console.WriteLine(people[meIndex]);
        //}


        //for (int i = 0; i < length; i++)
        //{
        //     
        //}
    }
}