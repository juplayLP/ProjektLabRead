﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace WinZugriffssteuerung
{
    class iButton
    {
        private SerialPort serport; //SerialPort-Object

        //Needed variables
        private string ids = string.Empty;
        private string com = "COM3"; //Used COM-Port                               
        
        public string read_IDs()
        {
            //Only for test if the data reading works fine
            try
            {
                serialinit();
                /*serport.Open(); //Opens the serial-connection
                
                ids = serport.ReadLine(); //Reads the data from the serial connection                

                if (ids.Length == 23)
                {
                    //Check if the data stored in IDs is a valid
                    serport.Close();
                    return ids;
                } //Output of the valid IDs
                else
                    MessageBox.Show("IDs fehlerhaft!"); //Error if the data in "mac" is not a valid MAC-Address

                ids = "";

                 //Closing the serial-connection
                 serport.Close();*/
                serport.Open();
                ids = serport.ReadLine();
                serport.Close();
                return ids;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"); //Shows an error if there is something wrong with the serial connection

                serport.Close(); //Closing the serial-connection
            }
            
            return "-";
        }

        public async Task<string> run()
        {
            return read_IDs();
        }

        private void serialinit()
        {
            serport = new SerialPort(com); //New instance of the SerialPort-Class with the used COM-Interface as transfer parameter
            serport.BaudRate = 115200; //Setting the BaudRate to 9600
            serport.Parity = Parity.None; //Setting Parity to None
            serport.DataBits = 8; //Used Bits for data is set to 8
            serport.StopBits = StopBits.One; //StopBit is set to 1
        }
    }

}

