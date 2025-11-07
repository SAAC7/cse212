public static class ComplexStack {
    public static void Main() {
        Console.WriteLine(DoSomethingComplicated("(a == 3 or (b == 5 and c == 6))")); // True:The stack is empty.
        Console.WriteLine(DoSomethingComplicated("(students]i].Grade > 80 and students[i].Grade < 90)"));  // False: There is an error with the bracket because it is a closing bracket and there is no opening bracket.
        Console.WriteLine(DoSomethingComplicated("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))")); // False:You are missing a closing “)”.
    }
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}