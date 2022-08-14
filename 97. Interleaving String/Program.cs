using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _97.Interleaving_String
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        char[] globalS1, globalS2, globalS3;
        bool[,] visited;

        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            globalS1 = s1.ToCharArray();
            globalS2 = s2.ToCharArray();
            globalS3 = s3.ToCharArray();
            visited = new bool[s1.Length + 1, s2.Length + 1];

            // visited = new bool[s3.Length, s2.Length];
            // s3Length = s3.Length;
            // s2Length = s2.Length;
            // check(s1, s2, s3, 0);

            return check(0, 0);
        }

        public bool check(int i1, int i2)
        {

            if (visited[i1, i2])
            {
                return false;
            }

            if (i1 == globalS1.Length && i2 == globalS2.Length)
            {
                return true;
            }

            bool pass = (i1 < globalS1.Length && globalS1[i1] == globalS3[i1 + i2] && check(i1 + 1, i2)) || (i2 < globalS2.Length && globalS2[i2] == globalS3[i1 + i2] && check(i1, i2 + 1));

            if (!pass)
            {
                visited[i1, i2] = true;
            }

            return pass;
        }


        /*
        bool[,] visited;
        int s2Length, s3Length;
        public void check(string s1, string s2, string s3, int prev){

            if(answer){
                return;
            }

            //base
            if(s2.Length==0){
                if(s1==s3){
                    Console.WriteLine("yay");
                    answer = true;
                }
                return;
            }

            int index = s3.IndexOf(s2[0], prev);
            if(index==-1){
                return;
            }

            if(index==s3.Length-1){
                //Console.WriteLine(s3+", " +s3.Substring(0,s3.Length-1));
                if(s2.Length==1 && s1==s3.Substring(0,s3.Length-1)){
                    answer = true;
                }
                return;
            }

            if(visited[s3Length - s3.Length + index, s2Length - s2.Length]){
                //if(s2.Length <5) {
                    Console.WriteLine("visited");
                //}
                return;
            }

            //if(s2.Length <5) {
                Console.WriteLine(s2+", " +s3+", "+prev +", "+index);
            //}


            if(s3.IndexOf(s2[0], index+1)!=-1){
                check(s1, s2, s3, index+1);
            }

            // if(index==0){
            //     s3 = s3.Substring(1);
            // }
            // else{
                s3 = s3.Substring(0, index) + s3.Substring(index+1);
            //}

            check(s1, s2.Substring(1), s3, index);

            if(!answer){
                visited[s3Length - s3.Length + index -1, s2Length - s2.Length] = true;
            }

        }
        */

    }
}
