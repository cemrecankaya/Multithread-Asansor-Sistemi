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
        private readonly int avmLoginSpeed = 500; // login thread çalışma aralığı
        private readonly int avmExitSpeed = 1000; // exit thread çalışma aralığı
        private Random rand = new Random();
        List<Elevator> elevator; // Asansörler
        List<Avmfloor> avmFloor; // Katlar
        Thread th_elevator0, th_elevator1, th_elevator2, th_elevator3, th_elevator4;
        Thread th_avmLogin, th_avmExit, th_queueControl,th_refresh;
        
        private bool simulationRunning = true; // Simulasyon çalışıyor mu?
        private bool avmLoginIsActive = true;
        private bool avmExitIsActive = true;
        private bool queueControlIsActive = true;

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
                     

            th_avmLogin = new Thread(new ThreadStart(avmLogin));
            th_avmLogin.Name = "AvmLogin";
            th_avmExit = new Thread(new ThreadStart(avmExit));
            th_avmExit.Name = "AvmExit";
            th_queueControl = new Thread(new ThreadStart(queueControl));
            th_queueControl.Name = "QueueControl";
            //th_refresh = new Thread(new ThreadStart(refreshQueueListbox));
            //th_refresh.Name = "Refresh";

        }
        #region MAIN
        private void simulationMain()
        {
            th_avmLogin.Start();
            th_avmExit.Start();
            th_refresh.Start();
        }
        private void başlat_Click(object sender, EventArgs e)
        {
            simulationMain();
        }
        #endregion

        private void start_elevator(int elevator)
        {
            switch (elevator)
            {
                case 1: elev_Mode[0] = true; 
                    th_elevator0 = new Thread(new ThreadStart(elevator0)); 
                    th_elevator0.Name = "Elevator0"; th_elevator0.Start(); break;
                case 2: elev_Mode[1] = true; 
                    th_elevator1 = new Thread(new ThreadStart(elevator1));
                    th_elevator1.Name = "Elevator1"; th_elevator1.Start(); break;
                case 3: elev_Mode[2] = true; 
                    th_elevator2 = new Thread(new ThreadStart(elevator2));
                    th_elevator2.Name = "Elevator2"; th_elevator2.Start(); break;
                case 4: elev_Mode[3] = true; 
                    th_elevator3 = new Thread(new ThreadStart(elevator3));
                    th_elevator3.Name = "Elevator3"; th_elevator3.Start(); break;
                case 5: elev_Mode[4] = true; 
                    th_elevator4 = new Thread(new ThreadStart(elevator4));
                    th_elevator4.Name = "Elevator4"; th_elevator4.Start(); break;
            }
        }
        private void stop_elevator(int elevator)
        {
            switch (elevator)
            {
                case 0: elev_Mode[0] = false; break;
                case 1: elev_Mode[1] = false; break;
                case 2: elev_Mode[2] = false; break;
                case 3: elev_Mode[3] = false; break;
                case 4: elev_Mode[4] = false; break;
            }
        }

        #region AVM
        private void avmLogin()
        {
            while (avmLoginIsActive)
            {
                string text = rand.Next(1, 11).ToString()+"-"+rand.Next(1,5);
                avmFloor[0].addFloorQueue(text);
                Thread.Sleep(avmLoginSpeed);
            }
        }
        private void avmExit()
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
        }
        /*
        private void avmExit()
        {
            while (avmExitIsActive)
            {
                string text = rand.Next(1, 6).ToString() + "-0";
                switch (rand.Next(1, 5))
                {
                    case 1: allFloorQueue[1].Enqueue(text); break;
                    case 2: allFloorQueue[2].Enqueue(text); break;
                    case 3: allFloorQueue[3].Enqueue(text); break;
                    case 4: allFloorQueue[4].Enqueue(text); break;
                }
                Thread.Sleep(avmExitSpeed);
            }
        }*/

        private void queueControl()
        {
            while (queueControlIsActive)
            {

            }
        }
        /*private void refreshQueueListbox()
        {
            
            while (simulationRunning) {
                List<Queue<string>> temp = new List<Queue<string>>();
                temp = .ToList();
                Thread.Sleep(1);
                listBox1.Items.Clear();
                listBox1.Items.Add("Floor 0: ");
                listBox1.Items.Add("Floor 1: ");
                listBox1.Items.Add("Floor 2: ");
                listBox1.Items.Add("Floor 3: ");
                listBox1.Items.Add("Floor 4: ");
                for (int i = 0; i < temp.Count; i++)
                {
                    foreach (var j in temp[i])
                    {
                        listBox1.Items[i] += "[" + j + "] ";
                    }
                }
                Thread.Sleep(301);
            }
        }*/
        #endregion

        #region ELEVATORS
        private void elevator0()
        {
            elevator[0].setActiveFloor(0);
            elevator[0].setDestinationFloor(0);
            elevator[0].setDirectionFloor(true);
            elevator[0].setMode(true);
            elevator[0].setTotalPersonInside(0);
            elevator[0].getInsidePersonList().Clear();
            
            while (elevator[0].getMode() == "Working") 
            {
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
                }  
                Thread.Sleep(floorTransitionSpeed);
            }
        }
        private void elevator1()
        {
            elevator[0].setActiveFloor(0);
            elevator[0].setDestinationFloor(0);
            elevator[0].setDirectionFloor(true);
            elevator[0].setMode(true);
            elevator[0].setTotalPersonInside(0);
            elevator[0].getInsidePersonList().Clear();

            while (elevator[0].getMode() == "Working")
            {


                Thread.Sleep(floorTransitionSpeed);
            }
        }
        private void elevator2()
        {
            int i = 0;
            while (elev_Mode[2])
            {
                elevator_2.Text = i.ToString();
                i++;
                Thread.Sleep(floorTransitionSpeed);
            }
            elevator_2.Text = "";
        }
        private void elevator3()
        {
            int i = 0;
            while (elev_Mode[3])
            {
                elevator_3.Text = i.ToString();
                i++;
                Thread.Sleep(floorTransitionSpeed);
            }
            elevator_3.Text = "";
        }
        private void elevator4()
        {
            int i = 0;
            while (elev_Mode[4])
            {
                elevator_4.Text = i.ToString();
                i++;
                Thread.Sleep(floorTransitionSpeed);
            }
            elevator_4.Text = "";
        }
        #endregion

    }
}
