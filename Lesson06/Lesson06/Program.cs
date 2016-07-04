﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    class Collection
    {
        int[] nums;
        int pos;

        public Collection()
        {
            nums = new int[10];
            pos = 0;
        }

        public Collection(int size)
        {
            nums = new int[size];
            pos = 0;
        }

        public void Add(int number)
        {
            if(pos == nums.Length)//no room!
            {
                int[] temp = new int[nums.Length * 2];
                for (int i = 0; i < nums.Length; i++)
                {
                    temp[i] = nums[i];
                }
                nums = temp;
            }
            nums[pos++] = number;
        }

        public int Get(int index)
        {
            if(index >= pos || index < 0)
            {
                throw new Exception("index out of bounds");
            }
            return nums[index];
        }
        //a e y z a m m
        public void Remove(int index)
        {
            if (index >= pos || index < 0)
            {
                throw new Exception("index out of bounds");
            }
            for (int i = index; i < pos; i++)
            {
                nums[i] = nums[i + 1];
            }
            pos--;
        }

        public int Size()
        {
            return pos;
        }

        public int[] ToArray()
        {
            
        }

        public int IndexOf(int number)
        {
            //returns the position/index of the element
            //in the array.
            //Returns, the first occurence of "number"
            //in the collection.
            //returns -1 if "number" doesn't exist.
        }

        //a c b j q e d 
        public void Insert(int number, int index)
        {

        }

        public void Set(int number, int index)
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Collection myCollection = new Collection(100);
            try
            {
                int q = Quotient(7, 0);
                Console.WriteLine("q=" + q);
            }
            catch(Exception ex)
            {
                Console.WriteLine("boom! " + ex.Message);
            }
            Console.WriteLine("done");
        }

        static int Quotient(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception("division by zero");
            }
            int sum = y;
            int result = 0;
            while (sum <= x)
            {
                result++;
                sum += y;
            }
            return result;
        }
    }
}