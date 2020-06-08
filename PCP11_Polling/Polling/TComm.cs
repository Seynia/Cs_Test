using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Polling
{
    static class TComm
    {
        //===================================================
        //  통신에 성공하면 true 리턴
        //  bits = 0x00 ~ 0xFF
        //===================================================
        public static bool SetDigitalOutput(SerialPort serialPort, bool[] bits)
        {
            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            // 데이터만들기
            int bitval = 0;
            if (bits[0]) bitval += 0x1;
            if (bits[1]) bitval += 0x2;
            if (bits[2]) bitval += 0x4;
            if (bits[3]) bitval += 0x8;
            if (bits[4]) bitval += 0x10;
            if (bits[5]) bitval += 0x20;
            if (bits[6]) bitval += 0x40;
            if (bits[7]) bitval += 0x80;

            // 명령송신
            string hexnum = Util.Hex(bitval);
            if (hexnum.Length == 1) hexnum = "0" + hexnum;
            string st = SPort.sSTX() + "DO" + hexnum + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 3)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "DO")
                    {
                        success = true;
                        break;
                    }
                }
            }
            return success;
        }

        //===========================================================
        //  통신에 성공하면 true 리턴
        //==========================================================
        public static bool AskDigitalInput(SerialPort serialPort, bool[] bits)
        {
            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            // 명령송신
            string st = SPort.sSTX() + "RI" + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2, indata;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 5)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "RI")
                    {
                        // 한개의찾음
                        string dd = rbuff.Substring(idx1 + 3, 2);
                        indata = Convert.ToInt32(dd, 16);//16진수10진수변환
                        success = true;
                        break;
                    }
                }
            }

            if (success)
            {
                bits[0] = ((indata & 0x1) > 0) ? true : false;
                bits[1] = ((indata & 0x2) > 0) ? true : false;
                bits[2] = ((indata & 0x4) > 0) ? true : false;
                bits[3] = ((indata & 0x8) > 0) ? true : false;
                bits[4] = ((indata & 0x10) > 0) ? true : false;
                bits[5] = ((indata & 0x20) > 0) ? true : false;
                bits[6] = ((indata & 0x40) > 0) ? true : false;
                bits[7] = ((indata & 0x80) > 0) ? true : false;
            }

            return success;
        }

        //===========================================================
        //  통신에 성공하면 true 리턴
        //===========================================================
        public static bool SetAnalogData(SerialPort serialPort, int[] davals)
        {
            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            // 데이터 만들기
            string[] hexnum = new string[4];
            for (int i = 0; i < 4; i++)
            {
                hexnum[i] = Util.Hex(davals[i]);
                if (hexnum[i].Length == 1) hexnum[i] = "0" + hexnum[i];
            }

            // 명령송신
            string st = SPort.sSTX() + "AO" + hexnum[0] + "," + hexnum[1] + "," +
                        hexnum[2] + "," + hexnum[3] + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 3)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "AO")
                    {
                        success = true;
                        break;
                    }
                }
            }
            return success;
        }

        //===========================================================
        //  통신에 성공하면 true 리턴
        //===========================================================
        public static bool AskADData(SerialPort serialPort, out int adval)
        {
            adval = 0;

            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            // 명령송신
            string st = SPort.sSTX() + "RA" + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 6)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "RA")
                    {
                        // 한 개의 block 찾음
                        string dds = rbuff.Substring(idx1 + 3, 3);
                        adval = Convert.ToInt32(dds, 16);   // 16진수를 10진수로변환
                        success = true;
                        break;
                    }
                }
            }
            return success;
        }

        public static bool AskAllData(SerialPort serialPort, bool[] bits, out int adval)
        {
            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            // 명령송신
            string st = SPort.sSTX() + "RB" + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2, indata, i, bit;
            bool success = false;
            string rbuff = "";
            adval = -1;
            while (!success) // 통신에 성공할때까지 반복
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 9)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "RB") //RB 코드가 올바로 수신되었으면 작동
                    {
                        string BTN = rbuff.Substring(idx1 + 3, 2); //Button Data 추출
                        string AD = rbuff.Substring(idx1 + 6, 3); //AD Data 추출
                        adval = Convert.ToInt32(AD, 16);//16진수10진수변환
                        indata = Convert.ToInt32(BTN, 16);//16진수10진수변환
                        for (i = 0, bit = 1; i < 8; i++, bit <<= 1) // 인덱스가 올라갈수록 비트 수도 올라가며 검증
                            bits[i] = ((indata & bit) > 0) ? true : false;
                        success = true; // 무사히 데이터 수신이 끝나면 플래그를 true로 변경
                    }
                }
            }
            return success;
        }
    }
} // end of class
