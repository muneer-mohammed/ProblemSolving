using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Geeks
{
    public class IsParenthesisBalanced
    {
        public bool IsBalanced(string input)
        {
            Stack<char> myStack = new Stack<char>();
            foreach (var item in input)
            {
                switch (item)
                {
                    case '{':
                    case '(':
                    case '[':
                        {
                            myStack.Push(item);
                            break;
                        }

                    case ')':
                        {
                            if (myStack.Count == 0 || myStack.Peek() != '(')
                            {
                                return false;
                            }

                            myStack.Pop();
                            break;
                        }
                    case ']':
                        {
                            if (myStack.Count == 0 || myStack.Peek() != '[')
                            {
                                return false;
                            }

                            myStack.Pop();

                            break;
                        }

                    case '}':
                        {
                            if (myStack.Count == 0 || myStack.Peek() != '{')
                            {
                                return false;
                            }

                            myStack.Pop();

                            break;
                        }

                    default: break;
                }

            }

            return myStack.Count == 0 ? true : false;
        }
    }
}
