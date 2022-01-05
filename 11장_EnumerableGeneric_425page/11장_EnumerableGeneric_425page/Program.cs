using System;
using System.Collections;
using System.Collections.Generic;

namespace _11장_EnumerableGeneric_425page
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array; // T 타입의 배열 선언;
        int position = -1; // 현재 index를 표시하기 위한 변수;

        public MyList()
        {
            array = new T[3];
            // MyList 생성자를 선언하는 순간 T타입의 값(또는 참조)을 3개 넣을 수 있는 배열 생성
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                    // 배열 사이즈가 index와 같거나 index보다 작을 경우 resize함
                }
                array[index] = value;
                // 그리고 그 위치에 값을 집어넣음
            }
        }

        public int Length
        {
            get { return array.Length; }
            // 배열 길이 반환하는 프로퍼티
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset(); // 다음에 또 foreach를 사용할 때를 대비해서 position 초기화
                return false; // 모두 돌았다면 반복문 foreach를 종료시키기 위해서 return false
            }

            position++;
            return (position < array.Length);
            // return true 할 수도 있겠지만
            // 혹시 모를 오류를 위해 직접 계산하도록 position< array<array.Length를 한 건가?
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            // do nothing
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach(string str in str_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            foreach (int no in int_list)
            {
                Console.WriteLine(no);
            }
            Console.WriteLine();
        }
    }
}