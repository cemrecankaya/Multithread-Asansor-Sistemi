using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreat_Elevator
{
    class Elevator
    {
        private readonly int capacity = 10; // Asansör kapasitesi
        private readonly int transitionSpeed = 200; // Katlar arası geçiş süresi
        private string mode; // Çalışma durumu  :  true = Working = Çalışıyor, false = Idle = Boşta 
        private int activeFloor; // Aktif olarak bulunduğu kat
        private int destinationFloor; // Hedeflediği kat
        private string directionFloor; // Hareket yönü  
        private int totalPersonInside; // İçerisindeki kişi sayısı
        private List<string> insidePersonList; // İçerideki kişilerin hedef listeleri
            //  InsidePersonList Format :  [0]= 6-2 , [1]= 1-4 , .....

        public Elevator()
        {
            this.mode = "Idle";
            this.activeFloor = 0;
            this.destinationFloor = 0;
            this.directionFloor = "up";
            this.totalPersonInside = 0;
            this.insidePersonList = new List<string>();
        }

        #region GET
        public string getMode()
        {//Çalışma durumunu döndürür.
            return this.mode;
        }
        public int getActiveFloor()
        {//Aktif olarak bulunduğu katı döndürür.
            return this.activeFloor;
        }
        public int getDestinationFloor()
        {//Hedeflenen kat numarasını döndürür.
            return this.destinationFloor;
        }
        public string getDirectionFloor()
        {//Gideceği yönü döndürür.
            return this.directionFloor;
        }
        public int getTotalPersonInside()
        {//İçeride bulunan kişi sayısını döndürür.
            return this.totalPersonInside;
        }
        public List<string> getInsidePersonList()
        {//İçeride bulunan kişi listesini döndürür.
            return this.insidePersonList;
        }
        public int getCapacity()
        {// Asansör kapasitesini döndürür.
            return this.capacity;
        }
        public int getTransitionSpeed()
        {// Asansör kat arası geçiş hızını döndürür.
            return this.transitionSpeed;
        }
        #endregion

        #region SET
        /// <summary>
        /// (true) = "Working",   (false) = "Idle".
        /// </summary> 
        public void setMode(bool control)
        {//Çalışma durumunu belirler.
            if (control)
                this.mode = "Working";
            else
                this.mode = "Idle";
        }
        public void setActiveFloor(int activeFloor)
        {//Aktif olarak bulunduğu katı belirler.
            this.activeFloor = activeFloor;
        }
        public void setDestinationFloor(int destinationFloor)
        {//Hedeflenen kat numarasını belirler.
            this.destinationFloor= destinationFloor;
        }        
        /// <summary>
        /// (true) = "Up",   (false) = "Down".
        /// </summary>
        public void setDirectionFloor(bool direction)
        {//Gideceği yönü belirler.
            if (direction)
                this.directionFloor = "Up";
            else
                this.directionFloor = "Down";
        }
        public void setTotalPersonInside(int totalPersonInside)
        {//İçeride bulunan kişi sayısını belirler.
            this.totalPersonInside= totalPersonInside;
        }
        #endregion

        #region Update
        public void addInsidePersonList(string text)
        {//İçeridekiler listesine kişi ekler.
            this.insidePersonList.Add(text);
        }
        public void removeInsidePersonList(string text)
        {//İçeridekiler listesinden kişi siler.
            this.insidePersonList.Remove(text);
            this.insidePersonList.Sort();
        }
        #endregion
    }
}
