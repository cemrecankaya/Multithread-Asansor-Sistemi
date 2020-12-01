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
        private Queue<string> floorQueue; // Katta bulunan asansör kuyruğu

        public Avmfloor(int floorNumber)
        {
            this.floorNumber = floorNumber;
            this.activePersonCount = 0;
            floorQueue = new Queue<string>();
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
        #endregion

        #region UPDATE
        /// <summary> 
        /// Katta aktif olarak bulunan kişi sayısını düzenler.
        /// (-) Negatif değer girildiğinde girilen değer kadar azaltır. 
        /// (+) Pozitif değer girildiğinde girilen değer kadar arttırır.
        /// </summary>          
        public void updateActivePersonCount(int number)
        { 
            if (number < 0)
                this.activePersonCount -= number;
            else
                this.activePersonCount += number;
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
