John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

Function Description

Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.

/*
 Problem:
 https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
 
*/

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
    static int sockMerchant(int n, int[] ar) {
        HashSet<int> hashset = new HashSet<int>();
        
        int totalPair = 0;
        for (int i = 0; i < n ; i++)
        {
            if (!hashset.Contains(ar[i]))
            {
                hashset.Add(ar[i]);
            }
            else
            {
                totalPair++;
                hashset.Remove(ar[i]);
            }
        }
        return totalPair;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));
        Console.WriteLine("{0}", sockMerchant(n, ar));
    }
}
