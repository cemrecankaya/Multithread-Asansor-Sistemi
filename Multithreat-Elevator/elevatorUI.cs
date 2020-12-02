using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Multithreat_Elevator
{
    public partial class elevatorUI : Form
    {        
        private Random rand = new Random();
        Thread th_elevator0, th_elevator1, th_elevator2, th_elevator3, th_elevator4;
        Thread th_avmLogin, th_avmExit, th_queueControl, th_refresh;
        
        private readonly int avmLoginSpeed = 500; // login thread çalışma aralığı
        private readonly int avmExitSpeed = 1000; // exit thread çalışma aralığı
        List<Elevator> elevator; // Asansörler
        List<Avmfloor> avmFloor; // Katlar
        
        private bool simulationRunning = true; // Simulasyon çalışıyor mu?
        private bool avmLoginIsActive = true; // Avm giriş thread çalışıyor mu?
        private bool avmExitIsActive = true; // Avm çıkış thread çalışıyor mu?
        private bool queueControlIsActive = true; // Avm kuyruk yoğunluğu thread çalışıyor mu?

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
            avmFloor[4].setActivePersonCount(15);
            avmFloor[2].setActivePersonCount(8);
        }

        #region MAIN
        private void simulationMain()
        {
            th_avmLogin = new Thread(new ThreadStart(avmLogin));
            th_avmLogin.Name = "AvmLogin";
            th_avmExit = new Thread(new ThreadStart(avmExit));
            th_avmExit.Name = "AvmExit";
            th_queueControl = new Thread(new ThreadStart(queueControl));
            th_queueControl.Name = "QueueControl";
            th_refresh = new Thread(new ThreadStart(refreshQueueListbox));
            th_refresh.Name = "Refresh";
            th_avmLogin.Start();
            th_avmExit.Start();
            th_refresh.Start();
        }
        #endregion

        #region AVM
        private void avmLogin()
        {
            while (avmLoginIsActive)
            {
                int personCount = rand.Next(1, 11);
                string text = personCount +"-"+rand.Next(1,5);
                avmFloor[0].addFloorQueue(text);
                avmFloor[0].updateActivePersonCount('+',personCount);
                Thread.Sleep(avmLoginSpeed);
            }
        }
        /*private void avmExit1()
        {
            while (avmExitIsActive)
            {
                string text = rand.Next(1, 6).ToString() + "-0";
                switch (rand.Next(1, 5))
                {
                    case 1: avmFloor[1].addFloorQueue(text); break;
                    case 2: avmFloor[2].addFloorQueue(text); break;
                    case 3: avmFloor[3].addFloorQueue(text); break;
                    case 4: avmFloor[4].addFloorQueue(text); break;
                }
                Thread.Sleep(avmExitSpeed);
            }
        }*/
        private void avmExit()
        {
            List<int> tempFloor = new List<int>();
            List<int> tempTotalPerson = new List<int>();
            while (avmExitIsActive)
            {
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
                    string text = personCount+ "-0";
                    switch (tempFloor[selectedIndex])
                    {
                        case 1: avmFloor[1].addFloorQueue(text); Console.WriteLine(avmFloor[1].getActivePersonCount()); avmFloor[1].updateActivePersonCount('-',personCount); Console.WriteLine(avmFloor[1].getActivePersonCount()); break;
                        case 2: avmFloor[2].addFloorQueue(text); avmFloor[2].updateActivePersonCount('-', personCount); break;
                        case 3: avmFloor[3].addFloorQueue(text); avmFloor[3].updateActivePersonCount('-', personCount); break;
                        case 4: avmFloor[4].addFloorQueue(text); avmFloor[4].updateActivePersonCount('-', personCount); break;
                    }
                }
                Thread.Sleep(avmExitSpeed);
            }
        }
        private void queueControl()
        {
            while (queueControlIsActive)
            {

            }
        }
        private void refreshQueueListbox()
        {
            List<Queue<string>> temp;
            List<Avmfloor> tempavm;
            Thread.Sleep(10);
            while (simulationRunning) 
            {
                richTextBox1.Clear();
                listBox1.Items.Clear();
                listBox1.Items.Add("Floor 4: ");
                listBox1.Items.Add("Floor 3: ");
                listBox1.Items.Add("Floor 2: ");
                listBox1.Items.Add("Floor 1: ");
                listBox1.Items.Add("Floor 0: ");
                        
                temp = new List<Queue<string>>
                {
                    new Queue<string>(avmFloor[0].getFloorQueue()),
                    new Queue<string>(avmFloor[1].getFloorQueue()),
                    new Queue<string>(avmFloor[2].getFloorQueue()),
                    new Queue<string>(avmFloor[3].getFloorQueue()),
                    new Queue<string>(avmFloor[4].getFloorQueue())
                };
                tempavm = new List<Avmfloor>(avmFloor);

                string text="";
                int m = 0;
                for (int i = 4; i >= 0; i--)
                {
                    listBox1.Items[i] += "Total Person : [ " + tempavm[m].getActivePersonCount() + " ] -- Queue : [ " + tempavm[m].getTotalPersonInQueue() + " ]";
                    text += "Floor " + i + ":";
                    foreach (string j in temp[i])
                    {
                       text += "[" + j + "] ";
                    }
                    text += "\n";
                    m++;
                }
                richTextBox1.Text = text;
                temp.Clear();
                tempavm.Clear();
                Thread.Sleep(500);
            }
        }
        #endregion

        #region ELEVATORS
        private void elevator0()
        { 
            // Asansör bilgilerinin sıfırlanması
            elevator[0].setActiveFloor(0);
            elevator[0].setDestinationFloor(0);
            elevator[0].setDirectionFloor(true);
            elevator[0].setMode(true);
            elevator[0].setTotalPersonInside(0);
            elevator[0].getInsidePersonList().Clear();
            
            while (elevator[0].getMode() == "Working") 
            {
                /* 
                 * Düzenlenecek !!!
                 * 
                // Asansörde kişi var ise ve bulunulan kat kişinin hedefi ise indir.
                if (elev_InsideCount[0] > 0)
                {
                    foreach (string inside in elev_InsideList[0])
                    {
                        string[] temp = inside.Split('-');
                        if (int.Parse(temp[1]) == elev_ActiveFloor[0])
                        {
                            elev_InsideList[0].Remove(inside);
                            elev_InsideCount[0] -= int.Parse(temp[0]);
                            elev_InsideList[0].Sort();
                            if (elev_ActiveFloor[0] == 0) 
                                avm_FloorTotalPerson[0] += int.Parse(temp[0]);
                            else
                                avm_FloorTotalPerson[elev_ActiveFloor[0]] += int.Parse(temp[0]);
                        }
                    }
                }
                if (allFloorQueue[elev_ActiveFloor[0]].Count > 0 ) // bulunduğu katta kuyrukta bekleyen insan var mı?
                {

                    if (elev_InsideCount[0] < CapasiteOfElevators && allFloorQueue[elev_ActiveFloor[0]].Count > 0) 
                    {
                        string[] temp = allFloorQueue[elev_ActiveFloor[0]].Peek().Split('-');
                        if ((int.Parse(temp[0]) + elev_InsideCount[0]) <= CapasiteOfElevators)
                        {
                            elev_InsideList[0].Add(allFloorQueue[elev_ActiveFloor[0]].Dequeue());
                            elev_InsideCount[0] += int.Parse(temp[0]);
                        }
                    }
                }  */
                if (elevator[0].getMode() == "Idle") break;
                Thread.Sleep(elevator[0].getTransitionSpeed());
            }
        }
        private void elevator1()
        {
            elevator[1].setActiveFloor(0);
            elevator[1].setDestinationFloor(0);
            elevator[1].setDirectionFloor(true);
            elevator[1].setMode(true);
            elevator[1].setTotalPersonInside(0);
            elevator[1].getInsidePersonList().Clear();

            while (elevator[1].getMode() == "Working")
            {




                if (elevator[1].getMode() == "Idle") break;
                Thread.Sleep(elevator[1].getTransitionSpeed());
            }
        }
        private void elevator2()
        {
            elevator[2].setActiveFloor(0);
            elevator[2].setDestinationFloor(0);
            elevator[2].setDirectionFloor(true);
            elevator[2].setMode(true);
            elevator[2].setTotalPersonInside(0);
            elevator[2].getInsidePersonList().Clear();

            while (elevator[2].getMode() == "Working")
            {



                if (elevator[2].getMode() == "Idle") break;
                Thread.Sleep(elevator[2].getTransitionSpeed());
            }
        }
        private void elevator3()
        {

            elevator[3].setActiveFloor(0);
            elevator[3].setDestinationFloor(0);
            elevator[3].setDirectionFloor(true);
            elevator[3].setMode(true);
            elevator[3].setTotalPersonInside(0);
            elevator[3].getInsidePersonList().Clear();

            while (elevator[3].getMode() == "Working")
            {



                if (elevator[3].getMode() == "Idle") break;
                Thread.Sleep(elevator[3].getTransitionSpeed());
            }
        }
        private void elevator4()
        {

            elevator[4].setActiveFloor(0);
            elevator[4].setDestinationFloor(0);
            elevator[4].setDirectionFloor(true);
            elevator[4].setMode(true);
            elevator[4].setTotalPersonInside(0);
            elevator[4].getInsidePersonList().Clear();

            while (elevator[4].getMode() == "Working")
            {



                if (elevator[4].getMode() == "Idle") break;
                Thread.Sleep(elevator[4].getTransitionSpeed());
            }
        }
        private void start_elevator(int elev)
        {
            switch (elev)
            {
                case 0:
                    elevator[0].setMode(true);
                    th_elevator0 = new Thread(new ThreadStart(elevator0));
                    th_elevator0.Name = "Elevator0"; th_elevator0.Start(); break;
                case 1:
                    elevator[1].setMode(true);
                    th_elevator1 = new Thread(new ThreadStart(elevator1));
                    th_elevator1.Name = "Elevator1"; th_elevator1.Start(); break;
                case 2:
                    elevator[2].setMode(true);
                    th_elevator2 = new Thread(new ThreadStart(elevator2));
                    th_elevator2.Name = "Elevator2"; th_elevator2.Start(); break;
                case 3:
                    elevator[3].setMode(true);
                    th_elevator3 = new Thread(new ThreadStart(elevator3));
                    th_elevator3.Name = "Elevator3"; th_elevator3.Start(); break;
                case 4:
                    elevator[4].setMode(true);
                    th_elevator4 = new Thread(new ThreadStart(elevator4));
                    th_elevator4.Name = "Elevator4"; th_elevator4.Start(); break;
            }
        }
        private void stop_elevator(int elev)
        {
            switch (elev)
            {
                case 0: elevator[0].setMode(false); break;
                case 1: elevator[1].setMode(false); break;
                case 2: elevator[2].setMode(false); break;
                case 3: elevator[3].setMode(false); break;
                case 4: elevator[4].setMode(false); break;
            }
        }
        #endregion

        #region EVENT
        private void elevatorUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            simulationRunning = false;
            stop_elevator(0);
            stop_elevator(1);
            stop_elevator(2);
            stop_elevator(3);
            stop_elevator(4);
            avmExitIsActive = false;
            avmLoginIsActive = false;
            queueControlIsActive = false;
        }
        private void start_Click(object sender, EventArgs e)
        {
            simulationRunning = true;
            avmExitIsActive = true;
            avmLoginIsActive = true;
            queueControlIsActive = true;
            simulationMain();

        }
        private void stop_Click(object sender, EventArgs e)
        {
            simulationRunning = false;
            stop_elevator(0);
            stop_elevator(1);
            stop_elevator(2);
            stop_elevator(3);
            stop_elevator(4);
            avmExitIsActive = false;
            avmLoginIsActive = false;
            queueControlIsActive = false;
        }
        #endregion
    }
}
