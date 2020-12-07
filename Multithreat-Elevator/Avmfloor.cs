using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreat_Elevator
{
    class Avmfloor
    {
        private int floorNumber; // Kat numarası
        private int activePersonCount; // Katta aktif olarak bulunan kişi sayısı
        private int leavingPersonCount; // Kattan ayrılan kişi sayısı
        private Queue<string> floorQueue; // Katta bulunan asansör kuyruğu
        private List<string> log;

        public Avmfloor(int floorNumber)
        {
            this.floorNumber = floorNumber;
            this.activePersonCount = 0;
            floorQueue = new Queue<string>();
            this.log = new List<string>();
        }
        
        #region GET
        public int getFloorNumber()
        {//Kat numarasını döndürür.
            return this.floorNumber;
        }
        public int getActivePersonCount()
        {//Katta aktif olarak bulunan kişi sayısını döndürür.
            return this.activePersonCount;
        }
        public Queue<string> getFloorQueue()
        {//Kat kuyruğu listesini döndürür.
            return this.floorQueue;
        }
        public int getLeavingPersonCount()
        {//Kattan ayrılan kişi sayısını döndürür.
            return this.leavingPersonCount;
        }
        public int getTotalPersonInQueue()
        {
            Queue<string> tempQueue = new Queue<string>(this.floorQueue);
            int count = 0;
            foreach(string temp in tempQueue)
            {
                string[] text = temp.Split('-');
                count += int.Parse(text[0]);
            }
            return count;
        }
        public List<string> getLog()
        {
            return this.log;
        }
        #endregion

        #region SET
        public void setFloorNumber(int floorNumber)
        {//Kat numarasını belirler.
            this.floorNumber=floorNumber;
        }
        /// <summary>
        /// Katta aktif olarak bulunan kişi sayısını girilen değere eşitler.
        /// </summary> 
        public void setActivePersonCount(int activePersonCount)
        {//Katta aktif olarak bulunan kişi sayısını belirler.
            this.activePersonCount = activePersonCount;
        }
        public void setLeavingPersonCount(int leavingPersonCount)
        {//Kattan ayrılan kişi sayısını belirler.
            this.leavingPersonCount = leavingPersonCount;
        }
        public void setLog(string text)
        {
            this.log.Add(text);
        }
        #endregion

        #region UPDATE
        /// <summary> 
        /// Katta aktif olarak bulunan kişi sayısını düzenler.
        /// (-) Negatif değer girildiğinde girilen değer kadar azaltır. 
        /// (+) Pozitif değer girildiğinde girilen değer kadar arttırır.
        /// </summary>          
        public void updateActivePersonCount(char oper,int number)
        {
            switch (oper)
            {
                case '+': this.activePersonCount += number; break;
                case '-': this.activePersonCount -= number; break;
            }
                
        }
        public void updateLeavingPersonCount(char oper,int number)
        {
            switch (oper)
            {
                case '+': this.leavingPersonCount += number; break;
                case '-': this.leavingPersonCount -= number; break;
            }
                
        }
        public void addFloorQueue(string text)
        {//Kuyruğun sonuna ekleme yapar
           this.floorQueue.Enqueue(text);
        }
        public void removeFloorQueue()
        {//Kuyruğun son değerini siler
           this.floorQueue.Dequeue();
        }
        #endregion
    }
}
