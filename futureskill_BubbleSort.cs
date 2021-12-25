using API;
using System;
using System.Collections.Generic;

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
         * Your solution should be entered here. Use the API to get information
         * about the list and to manipulate the contents.
         */
        public void SortTheList()
        {
            // Level 1
            // if(!api.IsOrdered(0, 1)){
            //     api.Swap(0, 1);
            // }
            
            // Level 2
            // int size = api.Size();
            // for(int i=0; i<size-1; i++){
            //     if(!api.IsOrdered(i, i+1)){
            //         api.Swap(i, i+1);
            //     }
            // }
            
            // Level 3
            // int size = api.Size();
            // for(int j=0; j<size-1; j++){
            //     for(int i=0; i<size-1; i++){
            //         if(!api.IsOrdered(i, i+1)){
            //             api.Swap(i, i+1);
            //         }
            //     }
            // }
            
            // Level 4
            int size = api.Size();
            while(true){
                int sortCheck = 0;
                for(int i=0; i<size-1; i++){
                    if(!api.IsOrdered(i, i+1)){
                        api.Swap(i, i+1);
                    }
                    else{
                        sortCheck++;
                    }
                }
                if(sortCheck==size-1){
                    break;
                }
            }
        }
    }
}