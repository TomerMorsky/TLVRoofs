using System;
using System.Collections.Generic;
using System.Text;
//Tomer Morsky(ID: 322622382) and Naor Hamisha(ID: 211899703)
namespace TLVRoofs
{
    public class TLVRoofChecker
    {
        public static int[] GetViewedBuildings(int[] buildingsHeights)
        {
            var indexesOfPotentionalBuildingsToBlockOthers = new NodesList<int>();
            var observedBuildings = new int[buildingsHeights.Length];
           
            for (int i = 0; i < buildingsHeights.Length; i++)
            {
                var firstNodeInList = indexesOfPotentionalBuildingsToBlockOthers.Head;
                
                while (firstNodeInList != null && buildingsHeights[firstNodeInList.Data] < buildingsHeights[i])
                {
                    indexesOfPotentionalBuildingsToBlockOthers.RemoveFirst();
                    firstNodeInList = indexesOfPotentionalBuildingsToBlockOthers.Head;
                }

                if (firstNodeInList != null)
                    observedBuildings[i] = firstNodeInList.Data + 1; // Because the number of the building is its index + 1
                
                indexesOfPotentionalBuildingsToBlockOthers.AddFirst(i);
            }

            return observedBuildings;
        }

    }
}
