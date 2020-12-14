using MultithreadElevator.Avm.avmFloor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadElevator.Avm.avmFloor.Concrete
{
    public class AvmFloor : IAvmFloor
    {
        private int floorNumber; // Kat numarası
        private int activePersonCount; // Katta aktif olarak bulunan kişi sayısı
        private int leavingPersonCount; // Kattan ayrılan kişi sayısı
        private Queue<int[]> floorQueue; // Katta bulunan asansör kuyruğu
        private List<string> log;
        public AvmFloor(int floorNumber)
        {
            this.floorNumber = floorNumber;
            this.activePersonCount = 0;
            this.floorQueue = new Queue<int[]>();
            this.log = new List<string>();
        }

        #region GET
        public int getFloorNumber() // Kat numarasını döndürür.
        {
            return this.floorNumber;
        }
        public int getActivePersonCount() // Katta aktif olarak bulunan kişi sayısını döndürür.
        {
            return this.activePersonCount;
        }
        public Queue<int[]> getFloorQueue() // Kat kuyruğu listesini döndürür.
        {
            return this.floorQueue;
        }
        public int getLeavingPersonCount() // Kattan ayrılan kişi sayısını döndürür.
        {
            return this.leavingPersonCount;
        }
        public int getTotalPersonInQueue() // Katta kuyrukta bekleyen kişi sayısını döndürür.
        {
            Queue<int[]> tempQueue = new Queue<int[]>(this.floorQueue);
            int count = 0;
            foreach (int[] temp in tempQueue)
            {
                count += temp[0];
            }
            return count;
        }
        public List<string> getLog()
        {
            return this.log;
        }
        #endregion

        #region SET
        public void setFloorNumber(int floorNumber) // Kat numarasını belirler.
        {
            this.floorNumber = floorNumber;
        }
        /// <summary>
        /// Katta aktif olarak bulunan kişi sayısını girilen değere eşitler.
        /// </summary> 
        public void setActivePersonCount(int activePersonCount) // Katta aktif olarak bulunan kişi sayısını belirler.
        {
            this.activePersonCount = activePersonCount;
        }
        public void setLeavingPersonCount(int leavingPersonCount) // Kattan ayrılan kişi sayısını belirler.
        {
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
        public void updateActivePersonCount(char oper, int number) // Aktif kullanıcı sayısını günceller.
        {
            switch (oper)
            {
                case '+': this.activePersonCount += number; break;
                case '-': this.activePersonCount -= number; break;
            }

        }
        public void updateLeavingPersonCount(char oper, int number) // Aktif ayrılan kişi sayısını belirler.
        {
            switch (oper)
            {
                case '+': this.leavingPersonCount += number; break;
                case '-': this.leavingPersonCount -= number; break;
            }

        }
        public void addFloorQueue(int personCount, int targetFloor) // Kuyruğun sonuna ekleme yapar
        {
            int[] temp = new int[] { personCount, targetFloor };
            this.floorQueue.Enqueue(temp);
        }
        public void removeFloorQueue() // Kuyruğun ilk değerini siler
        {
            this.floorQueue.Dequeue();
        }
        #endregion
    }
}
