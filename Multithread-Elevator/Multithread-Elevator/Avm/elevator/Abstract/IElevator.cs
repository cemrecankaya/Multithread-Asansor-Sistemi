using MultithreadElevator.Avm.avmFloor.Abstract;
using MultithreadElevator.Avm.avmFloor.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadElevator.Avm.elevator.Abstract
{
    public interface IElevator
    {
        #region GET    
        int getCapacity();
        int getTransitionSpeed();
        int getId();
        bool getStatus();
        bool getMode();
        int getActiveFloor();
        int getDestinationFloor();
        bool getDirectionFloor();
        int getTotalPersonInside();
        List<int[]> getInsideList();
        #endregion

        #region SET 
        void setTransitionSpeed(int value);
        void setId(int num);
        void setStatus(bool status);
        void setMode(bool control);
        void setActiveFloor(int activeFloor);
        void setDestinationFloor(int num);
        void setDirectionFloor(bool direction);
        void setTotalPersonInside(int totalPersonInside);
        #endregion

        #region UPDATE
        void updateTotalPersonInside(char oper, int number);  
        void updateActiveFloor(char oper, int number);
        void addInsideList(int personCount, int targetFloor);
        void removeInsideList(int personCount, int targetFloor);
        void sortInsideList();
        #endregion

        #region FUNCTION
        void elevatorMove();
        void elevatorSetDirection(List<AvmFloor> temp);
        void elevatorSetDestination(List<AvmFloor> temp);
        #endregion
    }
}
