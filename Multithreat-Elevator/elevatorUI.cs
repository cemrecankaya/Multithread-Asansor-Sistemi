using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
namespace Multithreat_Elevator
{
    public partial class elevatorUI : Form
    {
        Color Working = Color.Chocolate;
        Color Idle = Color.DarkGray;
        Color Active = Color.LimeGreen;
        Color Deactive = Color.IndianRed;
        private Random rand = new Random();
        Thread th_elevator0, th_elevator1, th_elevator2, th_elevator3, th_elevator4;
        Thread th_avmLogin, th_avmExit, th_queueControl, th_refresh;
        
        private readonly int avmLoginSpeed = 500; // login thread çalışma aralığı
        private readonly int avmExitSpeed = 1000; // exit thread çalışma aralığı
        private int sleepSpeedController = 100; // Yüzde kaç arttırılacak
        List<Elevator> elevator; // Asansörler
        List<Avmfloor> avmFloor; // Katlar
        List<List<Label>> elevLabel; // Asansör bilgilerinin gösterileceği label lar
        List<TextBox> elevTextbox; // Asansör içerisinde bulunan kişi ve hedeflerinin tutulduğu textbox lar

        private bool simulationRunning = true; // Simulasyon çalışıyor mu?
        private bool avmLoginIsActive = true; // Avm giriş thread çalışıyor mu?
        private bool avmExitIsActive = true; // Avm çıkış thread çalışıyor mu?
        private bool queueControlIsActive = true; // Avm kuyruk yoğunluğu thread çalışıyor mu?
        private bool[] elevatorIsActive; // Asansörler aktif mi?
        private bool gameStarted = true; // Oyun başladı mı?
        public elevatorUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            avmFloor = new List<Avmfloor>{
                new Avmfloor(0),
                new Avmfloor(1),
                new Avmfloor(2),
                new Avmfloor(3),
                new Avmfloor(4)
                };
            elevator = new List<Elevator>{
                new Elevator(),
                new Elevator(),
                new Elevator(),
                new Elevator(),
                new Elevator()
                };
            elevLabel = new List<List<Label>> {
                new List<Label>
                { 
                    elev_1_status,
                    elev_1_mode,
                    elev_1_floor,
                    elev_1_dest,
                    elev_1_direc,
                    elev_1_cap,
                    elev_1_totalInside
                },
                new List<Label>
                { 
                    elev_2_status,
                    elev_2_mode,
                    elev_2_floor,
                    elev_2_dest,
                    elev_2_direc,
                    elev_2_cap,
                    elev_2_totalInside
                },
                new List<Label>
                { 
                    elev_3_status,
                    elev_3_mode,
                    elev_3_floor,
                    elev_3_dest,
                    elev_3_direc,
                    elev_3_cap,
                    elev_3_totalInside
                },
                new List<Label>
                { 
                    elev_4_status,
                    elev_4_mode,
                    elev_4_floor,
                    elev_4_dest,
                    elev_4_direc,
                    elev_4_cap,
                    elev_4_totalInside
                },
                new List<Label>
                { 
                    elev_5_status,
                    elev_5_mode,
                    elev_5_floor,
                    elev_5_dest,
                    elev_5_direc,
                    elev_5_cap,
                    elev_5_totalInside
                }
            };
            elevTextbox = new List<TextBox>
            {
                elev_1_insideList,
                elev_2_insideList,
                elev_3_insideList,
                elev_4_insideList,
                elev_5_insideList
            };

            elevatorIsActive = new bool[5];
            elevatorIsActive[0] = true;
            elevatorIsActive[1] = false;
            elevatorIsActive[2] = false;
            elevatorIsActive[3] = false;
            elevatorIsActive[4] = false;
        }

        #region MAIN
        private void simulationMain()
        {
            th_avmLogin = new Thread(new ThreadStart(avmLogin));
            th_avmLogin.Name = "AvmLogin";
            th_avmExit = new Thread(new ThreadStart(avmExit));
            th_avmExit.Name = "AvmExit";
            th_queueControl = new Thread(new ThreadStart(queueDensityControl));
            th_queueControl.Name = "QueueControl";
            th_refresh = new Thread(new ThreadStart(refreshQueueListbox));
            th_refresh.Name = "Refresh";

            th_avmLogin.Start();
            th_avmExit.Start();
            th_queueControl.Start();
            th_refresh.Start();
            elevatorIsActive[0] = true;
            for (int i = 0; i < 5; i++) 
            {
                if (elevatorIsActive[i] == true) 
                elevatorStart(i);
            }
        }
        #endregion

        #region AVM
        private void avmLogin()
        {
            int count = 0;
            while (avmLoginIsActive)
            {
                avmLoginCount.Text = count.ToString();
                int personCount = rand.Next(1, 11);
                string text = personCount +"-"+rand.Next(1,5);
                avmFloor[0].addFloorQueue(text);
                avmFloor[0].updateActivePersonCount('+', personCount);
                Thread.Sleep((avmLoginSpeed*sleepSpeedController)/100);
                count++;
            }
        }
        private void avmExit()
        {
            int count = 0;
            List<int> tempFloor = new List<int>();
            List<int> tempTotalPerson = new List<int>();
            while (avmExitIsActive)
            {               
                lock (this)
                {
                    avmExitCount.Text = count.ToString();
                    tempFloor.Clear();
                    tempTotalPerson.Clear();
                    foreach (Avmfloor a in avmFloor)
                    {
                        if (a.getActivePersonCount() > 0 && a.getFloorNumber() > 0)
                        {
                            tempFloor.Add(a.getFloorNumber());
                            tempTotalPerson.Add(a.getActivePersonCount());
                        }
                    }
                    if (tempFloor.Count > 0)
                    {
                        int selectedIndex = rand.Next(0, tempFloor.Count());
                        int tempMaxPerson = 5;
                        if (tempTotalPerson[selectedIndex] < 5)
                            tempMaxPerson = tempTotalPerson[selectedIndex];

                        int personCount = rand.Next(1, (tempMaxPerson + 1));
                        string text = personCount + "-0";
                        avmFloor[tempFloor[selectedIndex]].addFloorQueue(text); avmFloor[tempFloor[selectedIndex]].updateActivePersonCount('-', personCount);
                        avmFloor[tempFloor[selectedIndex]].setLog(text + " Eklendi. Total person : " + avmFloor[tempFloor[selectedIndex]].getActivePersonCount());

                    }
                    count++;
                }
                Thread.Sleep((avmExitSpeed * sleepSpeedController) / 100);
            }
        }
        private void queueDensityControl()
        {
            int count = 0;
            while (queueControlIsActive)
            {
                lock (this)
                {
                    int allPersonCount = 0;
                    int allCapacity = 0;
                    controlThreadCount.Text = count.ToString();
                    for (int i = 0; i < 5; i++)
                    {
                        allPersonCount += avmFloor[i].getTotalPersonInQueue();
                        if (elevatorIsActive[i] == true)
                        {
                            allCapacity += elevator[i].getCapacity();
                        }
                    }

                    if (allPersonCount > (allCapacity * 2))
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            if (elevatorIsActive[i] == false)
                            {
                                elevatorStart(i);
                                break;
                            }
                        }
                    }
                    if (allPersonCount < allCapacity) 
                    {                        
                        for (int i = 4; i > 0; i--)
                        {
                            if (elevatorIsActive[i] == true)
                            {
                                elevatorStop(i);
                                break;
                            }
                        }
                    }
                }
                count++;
                Thread.Sleep((200 * sleepSpeedController) / 100);
            }
        }
        private void refreshQueueListbox()
        {
            while (simulationRunning) 
            {
                lock (this)
                {
                    int allQueueCount = 0; // Tüm katlarda kuyruklarda bekleyen toplam kişi sayısı
                    string text = ""; 
                    richTextBox1.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        allQueueCount += avmFloor[i].getTotalPersonInQueue();
                    }
                    floor_0_queue.Text = avmFloor[0].getTotalPersonInQueue().ToString();
                    floor_1_queue.Text = avmFloor[1].getTotalPersonInQueue().ToString();
                    floor_2_queue.Text = avmFloor[2].getTotalPersonInQueue().ToString();
                    floor_3_queue.Text = avmFloor[3].getTotalPersonInQueue().ToString();
                    floor_4_queue.Text = avmFloor[4].getTotalPersonInQueue().ToString();
                    floor_1_totalPerson.Text = avmFloor[1].getActivePersonCount().ToString();
                    floor_2_totalPerson.Text = avmFloor[2].getActivePersonCount().ToString();
                    floor_3_totalPerson.Text = avmFloor[3].getActivePersonCount().ToString();
                    floor_4_totalPerson.Text = avmFloor[4].getActivePersonCount().ToString();
                    totalPersonAllQueue.Text = allQueueCount.ToString();
                    totalPersonExit.Text = avmFloor[0].getLeavingPersonCount().ToString();
                    for(int i = 4; i >= 0; i--)
                    {
                        Queue<string> tempAvmFloor = new Queue<string>(avmFloor[i].getFloorQueue());
                        text += "Floor " + i + ":";
                        foreach (string j in tempAvmFloor)
                        {
                            text += "[" + j + "]";
                            if (tempAvmFloor.Last() != j)
                            {
                                text += "-";
                            }
                        }
                        text += "\n";
                    }
                    richTextBox1.Text = text;
                    text = "";
                    allQueueCount = 0;
                }
                Thread.Sleep((100 * sleepSpeedController) / 100);
            }
        }
        #endregion

        #region ELEVATORS
        private void elevator0()
        { 
            while (elevator[0].getMode() == "Working") 
            {
                lock (this)
                {
                    if (elevatorIsActive[0] == true)
                    {
                        // Asansörde kişi var ise ve bulunulan kat kişinin hedefi ise indir.
                        elevatorUnload(0);

                        // Bulunduğu katta kuyrukta bekleyen insan var mı?
                        elevatorLoad(0);

                        // En üst ve en alta ulaştı ise yönü tersine çevir
                        elevator[0].setElevatorDirection();

                        // Asansörü hareket ettir.
                        elevator[0].setElevatorMove();

                        // Ekrandaki bilgileri güncelle
                        elevatorRefresh(0);
                    }
                    else if (elevatorIsActive[0] == false)
                    {
                        elevatorUnload(0);
                        if (elevator[0].getDirectionFloor() == "Up" && elevator[0].getActiveFloor() == 4)
                        {
                            elevator[0].setDirectionFloor(false); elevator[0].setDestinationFloor(0);
                        }

                        if (elevator[0].getActiveFloor() == 0 && elevator[0].getDirectionFloor() == "Down") { }
                        else elevator[0].setElevatorMove();
                        
                        if (elevator[0].getActiveFloor() == 0)
                        {
                            elevatorUnload(0);
                            elevator[0].setMode(false);
                        }
                        elevatorRefresh(0);
                    }

                }
                Thread.Sleep((elevator[0].getTransitionSpeed() * sleepSpeedController) / 100);
            }
        }
        private void elevator1()
        {
            while (elevator[1].getMode() == "Working")
            {
                lock (this)
                {
                    if (elevatorIsActive[1] == true)
                    {
                        // Asansörde kişi var ise ve bulunulan kat kişinin hedefi ise indir.
                        elevatorUnload(1);

                        // Bulunduğu katta kuyrukta bekleyen insan var mı?
                        elevatorLoad(1);

                        // En üst ve en alta ulaştı ise yönü tersine çevir
                        elevator[1].setElevatorDirection();

                        // Asansörü hareket ettir.
                        elevator[1].setElevatorMove();

                        // Ekrandaki bilgileri güncelle
                        elevatorRefresh(1);
                    }
                    else if (elevatorIsActive[1] == false)
                    {
                        elevatorUnload(1);
                        if (elevator[1].getDirectionFloor() == "Up" && elevator[1].getActiveFloor() == 4)
                        {
                            elevator[1].setDirectionFloor(false); elevator[1].setDestinationFloor(0);
                        }

                        if (elevator[1].getActiveFloor() == 0 && elevator[1].getDirectionFloor() == "Down") { }
                        else elevator[1].setElevatorMove();

                        if (elevator[1].getActiveFloor() == 0)
                        {
                            elevatorUnload(1);
                            elevator[1].setMode(false);
                        }
                        elevatorRefresh(1);
                    }
                }
                Thread.Sleep((elevator[1].getTransitionSpeed() * sleepSpeedController) / 100);
            }
        }
        private void elevator2()
        {
            while (elevator[2].getMode() == "Working")
            {
                lock (this)
                {
                    if (elevatorIsActive[2] == true)
                    {
                        // Asansörde kişi var ise ve bulunulan kat kişinin hedefi ise indir.
                        elevatorUnload(2);

                        // Bulunduğu katta kuyrukta bekleyen insan var mı?
                        elevatorLoad(2);

                        // En üst ve en alta ulaştı ise yönü tersine çevir
                        elevator[2].setElevatorDirection();

                        // Asansörü hareket ettir.
                        elevator[2].setElevatorMove();

                        // Ekrandaki bilgileri güncelle
                        elevatorRefresh(2);
                    }
                    else if (elevatorIsActive[2] == false)
                    {
                        elevatorUnload(2);
                        if (elevator[2].getDirectionFloor() == "Up" && elevator[2].getActiveFloor() == 4)
                        {
                            elevator[2].setDirectionFloor(false); elevator[2].setDestinationFloor(0);
                        }

                        if (elevator[2].getActiveFloor() == 0 && elevator[2].getDirectionFloor() == "Down") { }
                        else elevator[2].setElevatorMove();
                        if (elevator[2].getActiveFloor() == 0)
                        {
                            elevatorUnload(2);
                            elevator[2].setMode(false);
                        }
                        elevatorRefresh(2);
                    }
                }
                Thread.Sleep((elevator[2].getTransitionSpeed() * sleepSpeedController) / 100);
            }
        }
        private void elevator3()
        {
            while (elevator[3].getMode() == "Working")
            {
                lock (this)
                {
                    if (elevatorIsActive[3] == true)
                    {
                        // Asansörde kişi var ise ve bulunulan kat kişinin hedefi ise indir.
                        elevatorUnload(3);

                        // Bulunduğu katta kuyrukta bekleyen insan var mı?
                        elevatorLoad(3);

                        // En üst ve en alta ulaştı ise yönü tersine çevir
                        elevator[3].setElevatorDirection();

                        // Asansörü hareket ettir.
                        elevator[3].setElevatorMove();

                        // Ekrandaki bilgileri güncelle
                        elevatorRefresh(3);
                    }
                    else if (elevatorIsActive[3] == false)
                    {
                        elevatorUnload(3);
                        if (elevator[3].getDirectionFloor() == "Up" && elevator[3].getActiveFloor() == 4)
                        {
                            elevator[3].setDirectionFloor(false); elevator[3].setDestinationFloor(0);
                        }
                        
                        if (elevator[3].getActiveFloor() == 0 && elevator[3].getDirectionFloor() == "Down") { }
                        else elevator[3].setElevatorMove();
                        
                        if (elevator[3].getActiveFloor() == 0)
                        {
                            elevatorUnload(3);
                            elevator[3].setMode(false);
                        }

                        elevatorRefresh(3);
                    }
                }
                Thread.Sleep((elevator[3].getTransitionSpeed() * sleepSpeedController) / 100); 
            }
        }
        private void elevator4()
        {
            while (elevator[4].getMode() == "Working")
            {
                lock (this)
                {
                    if (elevatorIsActive[4] == true)
                    {
                        // Asansörde kişi var ise ve bulunulan kat kişinin hedefi ise indir.
                        elevatorUnload(4);

                        // Bulunduğu katta kuyrukta bekleyen insan var mı?
                        elevatorLoad(4);

                        // En üst ve en alta ulaştı ise yönü tersine çevir
                        elevator[4].setElevatorDirection();

                        // Asansörü hareket ettir.
                        elevator[4].setElevatorMove();

                        // Ekrandaki bilgileri güncelle
                        elevatorRefresh(4);
                    }
                    else if (elevatorIsActive[4] == false)
                    {
                        elevatorUnload(4);
                        if (elevator[4].getDirectionFloor() == "Up" && elevator[4].getActiveFloor() == 4)
                        {
                            elevator[4].setDirectionFloor(false); elevator[4].setDestinationFloor(0);
                        }
                        
                        if (elevator[4].getActiveFloor() == 0 && elevator[4].getDirectionFloor() == "Down") { }
                        else elevator[4].setElevatorMove();
                        
                        if (elevator[4].getActiveFloor() == 0)
                        {
                            elevatorUnload(4);
                            elevator[4].setMode(false);
                        }
                        elevatorRefresh(4);
                    }
                }
                Thread.Sleep((elevator[4].getTransitionSpeed() * sleepSpeedController) / 100);
            }
        }
        private void elevatorStart(int num)
        {
            switch (num)
            {
                case 0:
                    if (elevator[0].getMode() == "Working")
                        elevatorIsActive[0] = true;
                    else
                    {
                        elevator[0].setMode(true);
                        th_elevator0 = new Thread(new ThreadStart(elevator0));
                        th_elevator0.Name = "Elevator0"; elevatorIsActive[0] = true;
                        th_elevator0.Start();
                    }
                    break;
                case 1:
                    if (elevator[1].getMode() == "Working")
                        elevatorIsActive[1] = true;
                    else
                    {
                        elevator[1].setMode(true);
                        th_elevator1 = new Thread(new ThreadStart(elevator1));
                        th_elevator1.Name = "Elevator1"; elevatorIsActive[1] = true;
                        th_elevator1.Start();
                    }
                    break;
                case 2:
                    if (elevator[2].getMode() == "Working")
                        elevatorIsActive[2] = true;
                    else
                    {
                        elevator[2].setMode(true);
                        th_elevator2 = new Thread(new ThreadStart(elevator2));
                        th_elevator2.Name = "Elevator2"; elevatorIsActive[2] = true;
                        th_elevator2.Start();
                    }
                    break;
                case 3:
                    if (elevator[3].getMode() == "Working")
                        elevatorIsActive[3] = true;
                    else
                    {
                        elevator[3].setMode(true);
                        th_elevator3 = new Thread(new ThreadStart(elevator3));
                        th_elevator3.Name = "Elevator3"; elevatorIsActive[3] = true;
                        th_elevator3.Start();
                    }
                    break;
                case 4:
                    if (elevator[4].getMode() == "Working")
                        elevatorIsActive[4] = true;
                    else
                    {
                        elevator[4].setMode(true);
                        th_elevator4 = new Thread(new ThreadStart(elevator4));
                        th_elevator4.Name = "Elevator4"; elevatorIsActive[4] = true;
                        th_elevator4.Start();
                    }
                    break;
            }
        }
        private void elevatorStop(int num)
        {
            switch (num)
            {
                case 0: elevatorIsActive[0] = false; break;
                case 1: elevatorIsActive[1] = false; break;
                case 2: elevatorIsActive[2] = false; break;
                case 3: elevatorIsActive[3] = false; break;
                case 4: elevatorIsActive[4] = false; break;
            }
        }
        private void elevatorUnload(int num)
        {
            if (elevator[num].getTotalPersonInside() > 0)
            {
                List<string> tempInsideList = new List<string>(elevator[num].getInsidePersonList());
                foreach (string inside in tempInsideList)
                {
                    string[] temp = inside.Split('-');
                    if (int.Parse(temp[1]) == elevator[num].getActiveFloor())
                    {
                        elevator[num].removeInsidePersonList(inside);
                        elevator[num].updateTotalPersonInside('-', int.Parse(temp[0]));
                        //elevator[num].setLog(temp[0] + "-" + temp[2] + " Asansör içerisinden çıkarıldı. Total inside : " + elevator[num].getTotalPersonInside());

                        if (elevator[num].getActiveFloor() == 0)
                        {
                            avmFloor[0].updateLeavingPersonCount('+', int.Parse(temp[0]));
                            //avmFloor[0].setLog(temp[0]+ " Kişi avmden ayrıldı." );
                        }
                        else
                        {
                            avmFloor[elevator[num].getActiveFloor()].updateActivePersonCount('+', int.Parse(temp[0]));
                            //avmFloor[elevator[num].getActiveFloor()].setLog(temp[0] + "-" + temp[2] + " Kişi kata ulaştı.");
                        }
                    }
                }
                elevator[num].getInsidePersonList().Sort();
            }
        }
        private void elevatorLoad(int num)
        {
                while (elevator[num].getTotalPersonInside() < elevator[num].getCapacity() && avmFloor[elevator[num].getActiveFloor()].getTotalPersonInQueue() > 0)
                {
                    string[] temp = avmFloor[elevator[num].getActiveFloor()].getFloorQueue().Peek().Split('-');
                    if ((int.Parse(temp[0]) + elevator[num].getTotalPersonInside()) <= elevator[0].getCapacity())
                    {
                        elevator[num].addInsidePersonList(avmFloor[elevator[num].getActiveFloor()].getFloorQueue().Dequeue());
                        elevator[num].updateTotalPersonInside('+', int.Parse(temp[0]));
                       // elevator[num].setLog(temp[0]+"-"+temp[2]+" Asansör içerisine eklendi. Total inside : "+ elevator[num].getTotalPersonInside());
                    }
                    else break;
                }
        }
        private void elevatorRefresh(int num)
        {
            elevTextbox[num].Clear();
            if (elevatorIsActive[num])
            {
                elevLabel[num][0].Text = "Active";
                elevLabel[num][0].ForeColor = Active;
            }
            else
            {
                elevLabel[num][0].Text = "Deactive";
                elevLabel[num][0].ForeColor = Deactive;
            }
            if (elevator[num].getMode() == "Working")
            {
                elevLabel[num][1].ForeColor = Working;
            }
            else if(elevator[num].getMode() == "Idle")
            {
                elevLabel[num][1].ForeColor = Idle;
            }
            elevLabel[num][1].Text = elevator[num].getMode();
            elevLabel[num][2].Text = elevator[num].getActiveFloor().ToString();
            elevLabel[num][3].Text = elevator[num].getDestinationFloor().ToString();
            elevLabel[num][4].Text = elevator[num].getDirectionFloor();
            elevLabel[num][5].Text = elevator[num].getCapacity().ToString();
            elevLabel[num][6].Text = elevator[num].getTotalPersonInside().ToString();
            foreach (string temptext in elevator[num].getInsidePersonList())
            {
                elevTextbox[num].Text += "[" + temptext + "] , ";
            }
        }
        #endregion

        #region EVENT
        private void threadSpeedRate_ValueChanged(object sender, EventArgs e)
        {
            speedValue.Text = "%" + (threadSpeedRate.Value * (-10));

            if (threadSpeedRate.Value == 10)
            {
                sleepSpeedController = 5;
            }
            else if (threadSpeedRate.Value > 0)
            {
                sleepSpeedController = 100 + (threadSpeedRate.Value * -10);
            }
            else if (threadSpeedRate.Value < 0)
            {
                sleepSpeedController = 100 + (threadSpeedRate.Value * -10);
            }
            else
            {
                sleepSpeedController = 100;
            }
        }
        private void elevatorUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            simulationRunning = false;
            elevator[0].setMode(false);
            elevator[1].setMode(false);
            elevator[2].setMode(false);
            elevator[3].setMode(false);
            elevator[4].setMode(false);
            elevatorStop(0);
            elevatorStop(1);
            elevatorStop(2);
            elevatorStop(3);
            elevatorStop(4);
            avmExitIsActive = false;
            avmLoginIsActive = false;
            queueControlIsActive = false;
        }
        private void start_Click(object sender, EventArgs e)
        {
            if (simulationRunning == false || gameStarted == true)
            {
                simulationRunning = true;
                avmExitIsActive = true;
                avmLoginIsActive = true;
                queueControlIsActive = true;
                simulationMain();
                gameStarted = false;
            }
        }
        private void stop_Click(object sender, EventArgs e)
        {
            simulationRunning = false;
            elevatorStop(0);
            elevatorStop(1);
            elevatorStop(2);
            elevatorStop(3);
            elevatorStop(4);
            avmExitIsActive = false;
            avmLoginIsActive = false;
            queueControlIsActive = false;
        }
        #endregion
    }
}
