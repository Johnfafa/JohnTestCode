using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms
{
    public class PhoneNumber
    {
        public IList<string> Combinations(string digits)
        {
            var dict = new Dictionary<char, char[]>
            {
                { '2',new[]{ 'a','b','c'} },
                { '3',new[]{ 'd','e','f'} },
                { '4',new[]{ 'g','h','i'} },
                { '5',new[]{ 'j','k','l'} },
                { '6',new[]{ 'm','n','o'} },
                { '7',new[]{ 'p','q','r','s'} },
                { '8',new[]{ 't','u','v'} },
                { '9',new[]{ 'w','x','y','z'} },
            };
            var result = new List<string>();
            if (string.IsNullOrEmpty(digits)) return result;
            var q = new Queue<string>();
            q.Enqueue(string.Empty);
            while(q.Count> 0)
            {
                var cur = q.Dequeue();
                if(cur.Length == digits.Length)
                {
                    result.Add(cur);
                }else
                    foreach(var c in dict[digits[cur.Length]])
                    {
                        q.Enqueue(cur + c);
                    }
            }

            return result;
        }

        public void Run()
        {
            var phoneNums = "24585639";
            var result = Combinations(phoneNums);
            File.WriteAllLines(@"D:\Study\Timothy\Algorithm\Algorithms\Algorithms\Algorithms\phonenumbers.txt",result);
        }
    }
}
