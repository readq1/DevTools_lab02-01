Wintellect.PowerCollections.Stack<int> stack = new();
Console.WriteLine(stack.Capacity);

for (int i = 0;i < stack.Capacity; i++)
{
    stack.Push(i);
    
}
for (int i = 0; i < stack.Count; i++)
{
    Console.WriteLine(stack.Pop());
}

