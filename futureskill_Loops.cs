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
         * Tell the dog to eat bone number 0. No loop necessary.
         */
        public void Level1()
        {
            api.EatBone(0);
        }

        /**
         * Let the dog eat bones numbered 0, 1 and 2.
         */
        public void Level2()
        {
            for(int i=0; i<3; i++){
                api.EatBone(i);
            }
        }

        /**
         * Use a loop to let the dog eat all bones. There 18 bones numbered from
         * 0 to 17.
         */
        public void Level3()
        {
            for(int i=0; i<18; i++){
                api.EatBone(i);
            }
        }

        /**
         * Let the dog eat only brown bones(8). There are 22 bones numbered from
         * 0 to 21.
         */
        public void Level4()
        {
            for(int i=0; i<22; i+=2){
                api.EatBone(i);
            }
        }

        /**
         * Let the dog eat all bones except for bone numbers 2, 4 and 5. There
         * are 10 bones numbered from 0 to 9. Use the continue keyword.
         */
        public void Level5()
        {
            for(int i=0; i<10; i++){
                if(i!=2 & i!=4 & i!=5){
                    api.EatBone(i);
                }
            }
        }

        /**
         * Let the dog eat available bones until it is time to go home. There are
         * 10 bones numbered from 0 to 9. Use the break keyword.
         */
        public void Level6()
        {
            for(int i=0; i<10; i++){
                if(api.IsTimeForBreak()){
                    break;
                }
                else
                    api.EatBone(i);
            }
        }

        /**
         * Let all dogs, eat their corresponding bones. Use nested loops.
         */
        public void Level7()
        {
            List<int> bones = new List<int>();
            for(int i=0; i<6; i++){
                bones = api.GetBonesForDog(i);
                for(int j=0; j<bones.Capacity; j++){
                    api.EatBoneForDog(i, bones[j]);
                }
            }
        }