using MultithreadElevator.Avm.avmFloor.Concrete;
using MultithreadElevator.Avm.elevator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace MultithreadElevator.UI
{
    public partial class elevatorScreen : Form
    {
        #region COLOR
        Color Working = Color.Chocolate;
        Color Idle = Color.DarkGray;
        Color Active = Color.LimeGreen;
        Color Deactive = Color.IndianRed;
        #endregion
        #region THREADS
        Thread th_elevator0, th_elevator1, th_elevator2, th_elevator3, th_elevator4;
        Thread th_avmLogin, th_avmExit, th_queueControl, th_refresh;
        #endregion
        #region THREADS TIME
        private int avmLoginSpeed = 500; // login thread çalışma aralığı
        private int avmExitSpeed = 1000; // exit thread çalışma aralığı
        private int queueDesintySpeed = 50; // exit thread çalışma aralığı
        private int refreshUISpeed = 50; // refreshUI thread çalışma aralığı
        private int sleepSpeedController = 100; // Thread hızları Yüzde kaç arttırılacak
        #endregion
        #region LIST OF ALL
        List<Elevator> elevatorList; // Asansörler
        List<AvmFloor> avmFloorList; // Katlar
        List<List<Label>> elevLabel; // Asansör bilgilerinin gösterileceği label lar
        List<TextBox> elevTextbox; // Asansör içerisinde bulunan kişi ve hedeflerinin tutulduğu textbox lar
        List<Thread> elevThreadList; // Asansör thread listesi
        List<ListBox> logListbox; // Log listbox listesi
        #endregion
        #region THREADS RUNNING CONTROL
        private bool simulationIsRunning = true; // Simulasyon çalışıyor mu?
        private bool avmLoginIsActive = true; // Avm giriş thread çalışıyor mu?
        private bool avmExitIsActive = true; // Avm çıkış thread çalışıyor mu?
        private bool queueControlIsActive = true; // Avm kuyruk yoğunluğu thread çalışıyor mu?
        private bool gameStarted = true; // Oyun başladı mı?
        #endregion
        #region MISC.
        private Random rand = new Random();
        #endregion

        public elevatorScreen()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            th_elevator0 = new Thread(new ThreadStart(() => elevator(0)));
            th_elevator1 = new Thread(new ThreadStart(() => elevator(1)));
            th_elevator2 = new Thread(new ThreadStart(() => elevator(2)));
            th_elevator3 = new Thread(new ThreadStart(() => elevator(3)));
            th_elevator4 = new Thread(new ThreadStart(() => elevator(4)));

            avmFloorList = new List<AvmFloor>{
                new AvmFloor(0),
                new AvmFloor(1),
                new AvmFloor(2),
                new AvmFloor(3),
                new AvmFloor(4)
                };
            elevatorList = new List<Elevator>{
                new Elevator(0),
                new Elevator(1),
                new Elevator(2),
                new Elevator(3),
                new Elevator(4)
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
            elevThreadList = new List<Thread> { 
                th_elevator0,
                th_elevator1,
                th_elevator2,
                th_elevator3,
                th_elevator4
            };
            logListbox = new List<ListBox> { 
                floorLog0,
                floorLog1,
                floorLog2,
                floorLog3,
                floorLog4
            };
        }

        #region MAIN
        private void simulationMain()
        {
            // Avm giriş, çıkış, kontrol ve arayüzü güncelleyen thread leri tekrar oluştur.
            th_avmLogin = new Thread(new ThreadStart(avmLogin));
            th_avmLogin.Name = "AvmLogin";
            th_avmExit = new Thread(new ThreadStart(avmExit));
            th_avmExit.Name = "AvmExit";
            th_queueControl = new Thread(new ThreadStart(queueDensityControl));
            th_queueControl.Name = "QueueControl";
            th_refresh = new Thread(new ThreadStart(refreshQueueUI));
            th_refresh.Name = "Refresh";

            // Threat leri başlat.
            th_avmLogin.Start();
            th_avmExit.Start();
            th_queueControl.Start();
            th_refresh.Start();

            // 1. asasörü aktif et ve eğer durdurmadan önce geri kalan asansörlerden aktif olanları da
            // var ise 1. asansörle birlikte çalıştır.
            elevatorList[0].setStatus(true);
            for (int i = 0; i < 5; i++)
            {
                if (elevatorList[i].getStatus() == true)
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
                lock (this)
                {
                    avmLoginCount.Text = count.ToString();
                    int tempPersonCount = rand.Next(1, 11);
                    int temptargetFloor = rand.Next(1, 5);
                    avmFloorList[0].addFloorQueue(tempPersonCount, temptargetFloor);
                    avmFloorList[0].updateActivePersonCount('+', tempPersonCount);
                    avmFloorList[0].setLog("[+] " + tempPersonCount + "-" + temptargetFloor);
                    count++;
                }
                Thread.Sleep(avmLoginSpeed);
            }
        }
        private void avmExit()
        {
            int count = 0;
            List<int> tempChoosableFloors = new List<int>();
            List<int> tempTotalPersonInQueues = new List<int>();
            while (avmExitIsActive)
            {
                lock (this)
                {
                    tempChoosableFloors.Clear();
                    tempTotalPersonInQueues.Clear();
                    // İçerisinde kişi bulunan katların listesi
                    foreach (AvmFloor temp in avmFloorList)
                    {
                        if (temp.getActivePersonCount() > 0 && temp.getFloorNumber() > 0)
                        {
                            tempChoosableFloors.Add(temp.getFloorNumber());
                            tempTotalPersonInQueues.Add(temp.getActivePersonCount());
                        }
                    }

                    if (tempChoosableFloors.Count > 0)
                    {
                        int selectedIndex = rand.Next(0, tempChoosableFloors.Count());
                        int tempMaxPerson = 5;
                        if (tempTotalPersonInQueues[selectedIndex] < 5)
                            tempMaxPerson = tempTotalPersonInQueues[selectedIndex];

                        int personCount = rand.Next(1, (tempMaxPerson + 1));
                        avmFloorList[tempChoosableFloors[selectedIndex]].addFloorQueue(personCount,0); 
                        avmFloorList[tempChoosableFloors[selectedIndex]].updateActivePersonCount('-', personCount);
                        avmFloorList[tempChoosableFloors[selectedIndex]].setLog("[+] "+personCount+"-0");
                    }
                    count++;
                    avmExitCount.Text = count.ToString();
                }
                Thread.Sleep(avmExitSpeed);
            }
        }
        private void queueDensityControl()
        {
            int count = 0;
            bool controlstart = false;
            bool controlstop = false;
            while (queueControlIsActive)
            {
                lock (this)
                {
                    int allPersonCount = 0;

                    // Tüm katlarda toplam kuyruktaki kişi sayısı ve toplam aktif asansör kapasitesi
                    for (int i = 0; i < 5; i++)
                    {
                        allPersonCount += avmFloorList[i].getTotalPersonInQueue();
                    }
                    
                    if (allPersonCount<=20)
                        controlstart = false;
                    if (allPersonCount >= 10)
                        controlstop = false;

                    // Tüm katlarda sırada bulunan toplam kişi sayısı aktif asansörlerin kapasitesinin iki katından fazla ise 1 tane asansör başlat
                    if (allPersonCount > 20 && controlstart == false)
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            if (elevatorList[i].getStatus() == false)
                            {
                                controlstart = true;
                                elevatorStart(i);
                                break;
                            }
                        }
                    }
                    // Tüm katlarda sırada bulunan toplam kişi sayısı aktif asansörlerin kapasitesinin altında ise 1 asansör kapat
                    if (allPersonCount < 10 && controlstop == false)
                    {
                        for (int i = 4; i > 0; i--)
                        {
                            if (elevatorList[i].getStatus() == true)
                            {
                                controlstop = true;
                                elevatorStop(i);
                                break;
                            }
                        }
                    }
                    count++;
                    controlThreadCount.Text = count.ToString();
                }
                Thread.Sleep(queueDesintySpeed);
            }
        }
        private void refreshQueueUI()
        {
            while (simulationIsRunning)
            {
                lock (this)
                {
                    int allQueueCount = 0; // Tüm katlarda kuyruklarda bekleyen toplam kişi sayısı
                    string text = "";
                    richTextBox1.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        allQueueCount += avmFloorList[i].getTotalPersonInQueue();
                        logListbox[i].Items.Clear();
                        elevatorRefreshUI(i);
                        foreach(string temp in avmFloorList[i].getLog())
                        {
                            logListbox[i].Items.Add(temp);
                        }
                    }
                    floor_0_queue.Text = avmFloorList[0].getTotalPersonInQueue().ToString();
                    floor_1_queue.Text = avmFloorList[1].getTotalPersonInQueue().ToString();
                    floor_2_queue.Text = avmFloorList[2].getTotalPersonInQueue().ToString();
                    floor_3_queue.Text = avmFloorList[3].getTotalPersonInQueue().ToString();
                    floor_4_queue.Text = avmFloorList[4].getTotalPersonInQueue().ToString();
                    floor_1_totalPerson.Text = avmFloorList[1].getActivePersonCount().ToString();
                    floor_2_totalPerson.Text = avmFloorList[2].getActivePersonCount().ToString();
                    floor_3_totalPerson.Text = avmFloorList[3].getActivePersonCount().ToString();
                    floor_4_totalPerson.Text = avmFloorList[4].getActivePersonCount().ToString();
                    totalPersonAllQueue.Text = allQueueCount.ToString();
                    totalPersonExit.Text = avmFloorList[0].getLeavingPersonCount().ToString();
                    for (int i = 4; i >= 0; i--)
                    {
                        Queue<int[]> tempFloorQueue = new Queue<int[]>(avmFloorList[i].getFloorQueue());
                        text += "Floor " + i + ":";
                        foreach (int[] temp in tempFloorQueue)
                        {
                            text += "[" + temp[0] + "-" + temp[1] + "]";
                            if (tempFloorQueue.Last() != temp)
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
                Thread.Sleep(refreshUISpeed);
            }
        }
        #endregion

        #region ELEVATORS
        private void elevator(int num)
        {
            Thread.Sleep(200);
            while(elevatorList[num].getMode() == true)
            {
                lock (this)
                {
                    if (elevatorList[num].getStatus() == true)
                    {
                        // Asansörün hedef yönünü belirle.
                        elevatorList[num].elevatorSetDirection(avmFloorList);

                        // Asansöre binecekleri bindir.
                        if (elevatorList[num].getActiveFloor() == 0 || elevatorList[num].getDirectionFloor() == false)
                            elevatorLoadPerson(num); 
                        
                        // Hedef belirleme.
                        elevatorList[num].elevatorSetDestination(avmFloorList);

                        // Arayüzde güncelleme.
                        elevatorRefreshUI(num);
                        
                        // Asansörü hareket ettir.
                        if (elevatorList[num].getMode() == true) 
                            elevatorList[num].elevatorMove();

                        // Asansörden inecekleri indir.
                        elevatorUnloadPerson(num);

                        // Arayüzde güncelleme.
                        elevatorRefreshUI(num);
                    }
                    //Asansör deaktif edildi ve asansörün içerisinde yolcu varsa onları indirip 0. kata git
                    else if (elevatorList[num].getStatus() == false)
                    {
                        // Asansörün hedef yönünü belirle.
                        elevatorList[num].elevatorSetDirection(avmFloorList);

                        // Hedef belirle.
                        elevatorList[num].elevatorSetDestination(avmFloorList);

                        // Arayüzde güncelleme.
                        elevatorRefreshUI(num);

                        // Asansörü hareket ettir.
                        if (elevatorList[num].getMode() == true)
                            elevatorList[num].elevatorMove();

                        // Asansörden inecekleri indir.
                        elevatorUnloadPerson(num);

                        // Arayüzde güncelleme.
                        elevatorRefreshUI(num);

                        // 0. kata ulaştı ise asansörü durdur.
                        if (elevatorList[num].getActiveFloor() == 0)
                        {
                            elevatorUnloadPerson(num);
                            elevatorList[num].setMode(false);
                        }
                        elevatorRefreshUI(num);
                    }
                }
                Thread.Sleep(elevatorList[num].getTransitionSpeed());
            }
        }
        private void elevatorStart(int num)
        {
            if (elevatorList[num].getMode() == true)
                elevatorList[num].setStatus(true);
            else
            {
                elevatorList[num].setMode(true);
                elevThreadList[num] = new Thread(new ThreadStart(() => elevator(num)));
                elevThreadList[num].Name = "Elevator" + num; 
                elevatorList[num].setStatus(true);
                elevThreadList[num].Start();
            }
        }
        private void elevatorStop(int num)
        {
            switch (num)
            {
                case 0: elevatorList[0].setStatus(false); break;
                case 1: elevatorList[1].setStatus(false); break;
                case 2: elevatorList[2].setStatus(false); break;
                case 3: elevatorList[3].setStatus(false); break;
                case 4: elevatorList[4].setStatus(false); break;
            }
        }
        private void elevatorUnloadPerson(int num)
        {
            if (elevatorList[num].getTotalPersonInside() > 0)
            {
                List<int[]> tempInsideList = new List<int[]>(elevatorList[num].getInsideList());
                foreach (int[] temp in tempInsideList)
                {
                    if (temp[1] == elevatorList[num].getActiveFloor())
                    {
                        elevatorList[num].removeInsideList(temp[0],temp[1]);
                        elevatorList[num].updateTotalPersonInside('-', temp[0]);

                        if (elevatorList[num].getActiveFloor() == 0)
                        {
                            avmFloorList[0].updateLeavingPersonCount('+', temp[0]);
                        }
                        else
                        {
                            avmFloorList[elevatorList[num].getActiveFloor()].updateActivePersonCount('+', temp[0]);
                        }
                    }
                }
            }
        }
        private void elevatorLoadPerson(int num)
        {
            while (elevatorList[num].getTotalPersonInside() < elevatorList[num].getCapacity() && avmFloorList[elevatorList[num].getActiveFloor()].getTotalPersonInQueue() > 0)
            {
                int[] temp = avmFloorList[elevatorList[num].getActiveFloor()].getFloorQueue().Peek();
                if ((temp[0] + elevatorList[num].getTotalPersonInside()) <= elevatorList[0].getCapacity())
                {
                    avmFloorList[elevatorList[num].getActiveFloor()].removeFloorQueue();
                    avmFloorList[elevatorList[num].getActiveFloor()].setLog("[-] " + temp[0] + "-" + temp[1] + " " + num + ". Asansör tarafından alındı.");
                    elevatorList[num].addInsideList(temp[0], temp[1]);
                    elevatorList[num].updateTotalPersonInside('+', temp[0]);
                }
                else if ((temp[0] + elevatorList[num].getTotalPersonInside()) > elevatorList[0].getCapacity())
                {
                    int remainingPersonCount = (temp[0] + elevatorList[num].getTotalPersonInside()) - 10;
                    int enteringPersonCount = temp[0] - remainingPersonCount;

                    avmFloorList[elevatorList[num].getActiveFloor()].getFloorQueue().Peek()[0] = remainingPersonCount;
                    elevatorList[num].addInsideList(enteringPersonCount, temp[1]);
                    elevatorList[num].updateTotalPersonInside('+', enteringPersonCount);
                    avmFloorList[elevatorList[num].getActiveFloor()].setLog("[-] " + enteringPersonCount + "-" + temp[1] + " " + num + ". Asansör tarafından alındı. Kapasite tamamlandı.");

                }
                else break;
            }
        }
        private void elevatorRefreshUI(int num)
        {
            elevTextbox[num].Clear();

            if (elevatorList[num].getStatus() == true)
            {
                elevLabel[num][0].Text = "Active";
                elevLabel[num][0].ForeColor = Active;
            }
            else
            {
                elevLabel[num][0].Text = "Deactive";
                elevLabel[num][0].ForeColor = Deactive;
            }

            if (elevatorList[num].getMode() == true)
            {
                elevLabel[num][1].Text = "Working";
                elevLabel[num][1].ForeColor = Working;
            }
            else if (elevatorList[num].getMode() == false)
            {
                elevLabel[num][1].Text = "Idle";
                elevLabel[num][1].ForeColor = Idle;
            }

            elevLabel[num][2].Text = elevatorList[num].getActiveFloor().ToString();
            elevLabel[num][3].Text = elevatorList[num].getDestinationFloor().ToString();
            
            if (elevatorList[num].getDirectionFloor() == true)
            {
                elevLabel[num][4].Text = "Up";
            }
            else if (elevatorList[num].getDirectionFloor() == false)
            {
                elevLabel[num][4].Text = "Down";
            }

            elevLabel[num][5].Text = elevatorList[num].getCapacity().ToString();
            elevLabel[num][6].Text = elevatorList[num].getTotalPersonInside().ToString();

            foreach (int[] temp in elevatorList[num].getInsideList())
            {
                elevTextbox[num].Text += "[" + temp[0] + "-" + temp[1] + "]";
                if(elevatorList[num].getInsideList().Last()!= temp)
                {
                    elevTextbox[num].Text += " , ";
                }
            }
        }
        #endregion

        #region EVENT
        private void threadSpeedRate_ValueChanged(object sender, EventArgs e)
        {
            

            if (threadSpeedRate.Value == 10)
            {
                sleepSpeedController = 5;
                speedValue.Text = "%" + (threadSpeedRate.Value * (10));

            }
            else if (threadSpeedRate.Value > 0)
            {
                sleepSpeedController = 100 + (threadSpeedRate.Value * -10);
                speedValue.Text = "%" + (threadSpeedRate.Value * (10));

            }
            else if (threadSpeedRate.Value < 0)
            {
                sleepSpeedController = 100 + (threadSpeedRate.Value * -50);
                speedValue.Text = "%" + (threadSpeedRate.Value * (50));

            }
            else
            {
                sleepSpeedController = 100;
            }
            avmLoginSpeed = (500 * sleepSpeedController) / 100; 
            avmExitSpeed = (1000 * sleepSpeedController) / 100;
            queueDesintySpeed =(50 * sleepSpeedController) / 100;

            foreach(Elevator temp in elevatorList)
            {
                temp.setTransitionSpeed(sleepSpeedController); 
            }
            
        }
        private void elevatorScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            simulationIsRunning = false;
            elevatorList[0].setMode(false);
            elevatorList[1].setMode(false);
            elevatorList[2].setMode(false);
            elevatorList[3].setMode(false);
            elevatorList[4].setMode(false);
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
            if (simulationIsRunning == false || gameStarted == true)
            {
                simulationIsRunning = true;
                avmExitIsActive = true;
                avmLoginIsActive = true;
                queueControlIsActive = true;
                simulationMain();
                gameStarted = false;
            }
        }
        private void stop_Click(object sender, EventArgs e)
        {
            elevatorStop(0);
            elevatorStop(1);
            elevatorStop(2);
            elevatorStop(3);
            elevatorStop(4);            
            simulationIsRunning = false;
            avmExitIsActive = false;
            avmLoginIsActive = false;
            queueControlIsActive = false;
        }
        #endregion
    }
}
