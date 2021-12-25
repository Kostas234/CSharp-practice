using API;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class Solution : ISolution
    {
        private APICaller api;

        public Solution(APICaller api)
        {
            this.api = api;
            // You can initiate and calculate things here
        }

        /**
         * Task 1: Return the number of unique numbers in the list.
         */
        public int UniqueNumbers()
        {   
            int result = 0;
            List<int> uniqueNums = new List<int>();
            int len = api.GetNumberCount();
            if(len!=0){
                for(int i = 0; i<len; i++){
                    if(!uniqueNums.Contains(api.GetNumber(i))){
                        uniqueNums.Add(api.GetNumber(i));
                        result++;
                    }
                }
            }
            return result;
        }

        /**
         * Task 2: Return the number of pairs in the list (see description for
         * how we define pairs).
         */
        public int NumberOfPairs()
        {
            int result = 0;
            int len = api.GetNumberCount();
            int appearances;
            List<int> checkedNums = new List<int>();
            
            if(len>1){
                for(int i = 0; i<len; i++){
                    appearances = 0; 
                    for(int j = 0; j<len; j++){
                        if(j!=i && !checkedNums.Contains(api.GetNumber(i))){
                            if(api.GetNumber(i)==api.GetNumber(j)){
                                appearances++;
                            }       
                        }
                    }
                    checkedNums.Add(api.GetNumber(i));
                    if(appearances==1){
                        result++;
                    }
                }
            }
            return result;
        }

        /**
         * Task 3: Return the highest pair in the list.
         */
        public int HighestPair()
        {
            int result = -1;
            int len = api.GetNumberCount();
            int appearances;
            List<int> pairNums = new List<int>();
            List<int> checkedNums = new List<int>();
            if(len>1){
                for(int i = 0; i<len; i++){
                    appearances = 0; 
                    for(int j = 0; j<len; j++){
                        if(j!=i && !checkedNums.Contains(api.GetNumber(i))){
                            if(api.GetNumber(i)==api.GetNumber(j)){
                                appearances++;
                            }       
                        }
                    }
                    checkedNums.Add(api.GetNumber(i));
                    if(appearances==1){
                        pairNums.Add(api.GetNumber(i));
                    }
                }
            }
            if(pairNums.Capacity>0){
                result = pairNums.Max();    
            }
            
            return result;
        }
    }
}