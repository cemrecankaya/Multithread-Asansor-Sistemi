using MultithreadElevator.Avm.elevator.Abstract;
using MultithreadElevator.Avm.avmFloor.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadElevator.Avm.elevator.Concrete
{
    public class Elevator : IElevator
    {
        private readonly int capacity = 10; // Asansör kapasitesi
        private int transitionSpeed = 200; // Katlar arası geçiş süresi
        private int id; // Asansör numarası
        private bool status; // Asansörün durumu
        private bool mode; // Anlık çalışma durumu  :  true = Working = Çalışıyor, false = Idle = Boşta 
        private int activeFloor; // Aktif olarak bulunduğu kat
        private int destinationFloor; // Hedeflediği kat
        private bool directionFloor; // Hareket yönü  
        private int totalPersonInside; // İçerisindeki kişi sayısı
        private List<int[]> insideList; // İçerideki kişilerin hedef listeleri
        // insideList Format :  insideList[0][0]= 6 , insideList[0][1]= 4  =>  [6 - 4], .....


        public Elevator(int id)
        {
            this.id = id;
            this.mode = false;
            this.activeFloor = 0;
            this.destinationFloor = 0;
            this.directionFloor = true;
            this.totalPersonInside = 0; 
            this.insideList = new List<int[]>();
        }

        #region GET
        public int getCapacity()// Asansör kapasitesini döndürür.
        {
            return this.capacity;
        }
        public int getTransitionSpeed()// Asansör kat arası geçiş hızını döndürür.
        {
            return this.transitionSpeed;
        }
        public int getId()//Asansör numarasını döndürür.
        {
            return this.id;
        }
        public bool getStatus()//Asansörün kullanıma açık olup olmadığını döndürür.
        {
            return this.status;
        }
        public bool getMode()// Anlık olarak çalışma durumunu döndürür.
        {
            return this.mode;
        }
        public int getActiveFloor()//Anlık olarak bulunduğu katı döndürür.
        {
            return this.activeFloor;
        }
        public int getDestinationFloor()//Hedeflenen kat numarasını döndürür.
        {
            return this.destinationFloor;
        }
        public bool getDirectionFloor()//Gideceği yönü döndürür.
        {
            return this.directionFloor;
        }
        public int getTotalPersonInside()//İçeride bulunan kişi sayısını döndürür.
        {
            return this.totalPersonInside;
        }
        public List<int[]> getInsideList()//İçeride bulunan kişi listesini döndürür.
        {
            return this.insideList;
        }
        #endregion

        #region SET     
        public void setTransitionSpeed(int value)// Asansör kapasitesini belirler.
        {
            this.transitionSpeed = (200 * value) / 100; 
        }
        public void setId(int num)// Asansör numarası belirler.
        {
            this.id = num;
        }
        /// <summary>
        /// (true) = "Active",   (false) = "Deactive".
        /// </summary> 
        public void setStatus(bool status)// Asansörün kullanıma açık olup olmadığını belirler. 
        {
            this.status = status;
        }
        /// <summary>
        /// (true) = "Working",   (false) = "Idle".
        /// </summary> 
        public void setMode(bool control)//Anlık Çalışma durumunu belirler.
        {
            this.mode = control;
        }
        public void setActiveFloor(int activeFloor)//Aktif olarak bulunduğu katı belirler.
        {
            this.activeFloor = activeFloor;
        }
        public void setDestinationFloor(int num)//Hedeflenen kat numarasını belirler.
        {
            this.destinationFloor = num;
        }        
        /// <summary>
        /// (true) = "Up",   (false) = "Down".
        /// </summary>
        public void setDirectionFloor(bool direction)//Gideceği yönü belirler.
        {
            this.directionFloor = direction;
        }
        public void setTotalPersonInside(int totalPersonInside)//İçeride bulunan kişi sayısını belirler.
        {
            this.totalPersonInside= totalPersonInside;
        }
        #endregion

        #region UPDATE
        /// <summary> 
        /// (-) Negatif değer girildiğinde girilen değer kadar azaltır. 
        /// (+) Pozitif değer girildiğinde girilen değer kadar arttırır.
        /// </summary>  
        public void updateTotalPersonInside(char oper, int number)//Asansör içerininde bulunan kişi sayısını düzenler.
        {
            switch (oper)
            {
                case '+': this.totalPersonInside += number; break;
                case '-': this.totalPersonInside -= number; break;
            }
        }
        /// <summary> 
        /// (-) Negatif değer girildiğinde girilen değer kadar azaltır. 
        /// (+) Pozitif değer girildiğinde girilen değer kadar arttırır.
        /// </summary>  
        public void updateActiveFloor(char oper, int number)//Asansörün aktif konumunu düzenler.
        {
            switch (oper)
            {
                case '+': this.activeFloor += number; break;
                case '-': this.activeFloor -= number; break;
            }
        }
        public void addInsideList(int personCount, int targetFloor)// İçeridekiler listesine kişi ekler.
        {
            int[] temp = new int[] { personCount, targetFloor };
            this.insideList.Add(temp);
            this.sortInsideList();
        }
        public void removeInsideList(int personCount, int targetFloor)// İçeridekiler listesinden kişi çıkarır.
        {
            for (int i = 0; i < this.insideList.Count; i++) 
            {
                if(this.insideList[i][0]==personCount && this.insideList[i][1] == targetFloor)
                {
                    this.insideList.RemoveAt(i);
                    break;
                }
            }
            this.sortInsideList();
        }
        public void sortInsideList()// Asansör içerisindekiler listesini hedef katlara göre sıralar.
        {
            this.insideList = this.insideList.OrderBy(x => x[1]).ToList();
        }
        #endregion

        #region FUNCTION
        public void elevatorMove()// Asansörü hareket ettirir.
        {
            if (this.directionFloor == true)
                this.updateActiveFloor('+', 1);
            else if (this.directionFloor == false)
                this.updateActiveFloor('-', 1);
        }
        public void elevatorSetDirection(List<AvmFloor> temp)// Asansörün hareket yönünü belirler.
        {
            // Asansör çağıran katlar
            List<int> tempTargetableFloor = new List<int>();
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].getTotalPersonInQueue() > 0)
                {
                    tempTargetableFloor.Add(i);
                }
            }
            tempTargetableFloor.Sort();
            
            //En üst ve en alt katta ise yönü terse çevir
            if (this.activeFloor == 4)
            {
                this.setDirectionFloor(false);
            }
            else if (this.activeFloor == 0)
            {
                this.setDirectionFloor(true);
            }

            // Asansör yukarı çıkıyor ise
            if (this.directionFloor == true)
            {
                // Asansör içerisinde kişi var ise
                if (this.insideList.Count() > 0)
                {
                    this.setDirectionFloor(true);
                }
                // Asansör içerisinde kimse kalmadı ise
                if (this.insideList.Count() == 0)
                {
                    bool control = false;
                    foreach (int tempFloor in tempTargetableFloor)
                    {
                        // Üst katlarda bekleyen var mı? 
                        if (tempFloor > this.activeFloor)
                        {
                            this.setDirectionFloor(true);
                            control = true;
                            break;
                        }
                    }
                    // Üst katta bekleyen yok ise
                    if (control == false && this.activeFloor > 0)
                    {
                        this.setDirectionFloor(false);
                    }
                    else if (control == false && this.activeFloor == 0)
                    {
                        this.setDirectionFloor(true);
                    }
                }
            }
            // Asansör iniyor ise
            else if (this.directionFloor == false)
            {
                if (tempTargetableFloor.Count > 0)
                {
                    for (int i = (tempTargetableFloor.Count - 1); i >= 0; i--)
                    {
                        if (tempTargetableFloor[i] < this.activeFloor)
                        {
                            this.setDirectionFloor(false);
                            break;
                        }
                    }
                }
                else
                {
                    this.setDirectionFloor(false);
                }
            }
        }
        public void elevatorSetDestination(List<AvmFloor> temp)// Asansörün hedef katını belirler.
        { 
            List<int> tempTargetableFloor = new List<int>();
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].getTotalPersonInQueue() > 0)
                {
                    tempTargetableFloor.Add(i);
                }
            }
            tempTargetableFloor.Sort();
            
            if (this.directionFloor == true)
            {
                if (this.insideList.Count() > 0)
                {
                    this.setDestinationFloor(this.insideList[0][1]);
                }
                if (this.insideList.Count() == 0)
                {
                    bool control = false;
                    foreach (int tempFloor in tempTargetableFloor)
                    {
                        if (tempFloor > this.activeFloor && this.status == true)
                        {
                            this.setDestinationFloor(tempFloor);
                            control = true;
                            break;
                        }
                    }
                    if (control == false && this.activeFloor > 0)
                    {
                        this.setDestinationFloor(0);
                    }
                    else if(control == false && this.activeFloor == 0)
                    {
                        this.setDestinationFloor(1);
                    }
                }
            }
            
            if (this.directionFloor == false)
            {
                if (tempTargetableFloor.Count > 0)
                {
                    for(int i= (tempTargetableFloor.Count - 1); i >= 0; i--)
                    {
                        if (tempTargetableFloor[i] < this.activeFloor)
                        {
                            this.setDestinationFloor(tempTargetableFloor[i]);
                            break;
                        }
                    }
                }
                else
                {
                    this.setDestinationFloor(0);
                }
            }
        }
        #endregion
    }
}
