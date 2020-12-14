using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadElevator.Avm.avmFloor.Abstract
{
    public interface IAvmFloor
    {
        #region GET
        int getFloorNumber();
        int getActivePersonCount();
        Queue<int[]> getFloorQueue();
        int getLeavingPersonCount();
        int getTotalPersonInQueue();
        #endregion

        #region SET
        void setFloorNumber(int floorNumber);
        void setActivePersonCount(int activePersonCount);
        void setLeavingPersonCount(int leavingPersonCount);
        #endregion

        #region UPDATE
        void updateActivePersonCount(char oper, int number);
        void updateLeavingPersonCount(char oper, int number);
        void addFloorQueue(int personCount, int targetFloor);
        void removeFloorQueue();
        #endregion
    }
}