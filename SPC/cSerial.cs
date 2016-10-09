using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SPC
{
    public class cSerial
    {
        // Methods
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int CloseHandle(int int_0);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int CreateFileA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int DeviceIoControl(int int_0, int int_1, [In, Out] SENDCMDINPARAMS sendcmdinparams_0, int int_2, [In, Out] SENDCMDOUTPARAMS sendcmdoutparams_0, int int_3, ref int int_4, int int_5);
        public bool GetHDData(int lDriveNumber, ref string sSerial, ref string sModel, ref string sFirmware)
        {
            int num2;
            bool flag = false;
            SENDCMDINPARAMS sendcmdinparams = new SENDCMDINPARAMS();
            SENDCMDOUTPARAMS structure = new SENDCMDOUTPARAMS();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                string valueref = @"\\.\PhysicalDrive" + Conversions.ToString(lDriveNumber);
                num2 = CreateFileA(ref (valueref) , -1073741824, 3, 0, 3, 0, 0);
            }
            else
            {
                string str = @"\\.\Smartvsd";
                num2 = CreateFileA(ref str, 0, 0, 0, 1, 0, 0);
            }
            if (num2 != -1)
            {
                int num3;
                sendcmdinparams.bDriveNumber = (byte)lDriveNumber;
                sendcmdinparams.cBufferSize = Marshal.SizeOf(structure);
                sendcmdinparams.irDriveRegs.bDriveHeadReg = (byte)(160 | (lDriveNumber << 4));
                sendcmdinparams.irDriveRegs.bCommandReg = 236;
                sendcmdinparams.irDriveRegs.bSectorCountReg = 1;
                sendcmdinparams.irDriveRegs.bSectorNumberReg = 1;
                if (DeviceIoControl(num2, 508040, sendcmdinparams, Marshal.SizeOf(sendcmdinparams), structure, Marshal.SizeOf(structure), ref num2, 0) != 0)
                {
                    sSerial = this.method_0(structure.idsector_0.sSerialNumber);
                    sModel = this.method_0(structure.idsector_0.sModelNumber);
                    sFirmware = this.method_0(structure.idsector_0.sFirmwareRev);
                    flag = true;
                }
                CloseHandle(num2);
            }
            return flag;
        }

        private string method_0(char[] char_0)
        {
            int num = char_0.Length - 2;
            for (int i = 0; i <= num; i += 2)
            {
                Array.Reverse(char_0, i, 2);
            }
            return new string(char_0).Trim();
        }

        // Nested Types
        [StructLayout(LayoutKind.Sequential, Size = 12)]
        public class DRIVERSTATUS
        {
            public byte bDriveError;
            public byte bIDEStatus;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] bReserved = new byte[2];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] dwReserved = new int[2];
        }

        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public class IDEREGS
        {
            public byte bFeaturesReg;
            public byte bSectorCountReg;
            public byte bSectorNumberReg;
            public byte bCylLowReg;
            public byte bCylHighReg;
            public byte bDriveHeadReg;
            public byte bCommandReg;
            public byte bReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class IDSECTOR
        {
            public short wGenConfig;
            public short wNumCyls;
            public short wReserved;
            public short wNumHeads;
            public short wBytesPerTrack;
            public short wBytesPerSector;
            public short wSectorsPerTrack;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] wVendorUnique = new short[3];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public char[] sSerialNumber = new char[20];
            public short wBufferclass;
            public short wBufferSize;
            public short wECCSize;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public char[] sFirmwareRev = new char[8];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public char[] sModelNumber = new char[40];
            public short wMoreVendorUnique;
            public short wDoubleWordIO;
            public short wCapabilities;
            public short wReserved1;
            public short wPIOTiming;
            public short wDMATiming;
            public short wBS;
            public short wNumCurrentCyls;
            public short wNumCurrentHeads;
            public short wNumCurrentSectorsPerTrack;
            public int ulCurrentSectorCapacity;
            public short wMultSectorCapacity;
            public short wMultSectorStuff;
            public int ulTotalAddressableSectors;
            public short wSingleWordDMA;
            public short wMultiWordDMA;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 382)]
            public byte[] bReserved = new byte[382];
        }

        [StructLayout(LayoutKind.Sequential, Size = 32)]
        public class SENDCMDINPARAMS
        {
            public int cBufferSize;
            public cSerial.IDEREGS irDriveRegs = new cSerial.IDEREGS();
            public byte bDriveNumber;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] bReserved = new byte[3];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] dwReserved = new int[4];
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SENDCMDOUTPARAMS
        {
            public int cBufferSize;
            public cSerial.DRIVERSTATUS DStatus = new cSerial.DRIVERSTATUS();
            public cSerial.IDSECTOR idsector_0 = new cSerial.IDSECTOR();
        }
    }


}
