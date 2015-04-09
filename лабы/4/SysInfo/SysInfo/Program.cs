using System.Runtime.InteropServices;
using System;

namespace SysInfo
{
    public class Win32Api
    {
        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern void GetSystemInfo(out SYSTEM_INFO Info);

        public enum ProcessorArchitecture
        {
            X86 = 0,
            X64 = 9,
            @Arm = -1,
            Itanium = 6,
            Unknown = 0xFFFF,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SystemInfo
        {
            public ProcessorArchitecture ProcessorArchitecture; // WORD
            public uint PageSize; // DWORD
            public IntPtr MinimumApplicationAddress; // (long)void*
            public IntPtr MaximumApplicationAddress; // (long)void*
            public IntPtr ActiveProcessorMask; // DWORD*
            public uint NumberOfProcessors; // DWORD (WTF)
            public uint ProcessorType; // DWORD
            public uint AllocationGranularity; // DWORD
            public ushort ProcessorLevel; // WORD
            public ushort ProcessorRevision; // WORD
        }

        [StructLayout(LayoutKind.Explicit)]

        public struct SYSTEM_INFO_UNION
        {

            [FieldOffset(0)]
            public UInt32 OemId;
            [FieldOffset(0)]
            public UInt16 ProcessorArchitecture;
            [FieldOffset(2)]
            public UInt16 Reserved;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]

        public struct SYSTEM_INFO
        {

            public SYSTEM_INFO_UNION CpuInfo;
            public UInt32 PageSize;
            public UInt32 MinimumApplicationAddress;
            public UInt32 MaximumApplicationAddress;
            public UInt32 ActiveProcessorMask;
            public UInt32 NumberOfProcessors;
            public UInt32 ProcessorType;
            public UInt32 AllocationGranularity;
            public UInt16 ProcessorLevel;
            public UInt16 ProcessorRevision;
        }
    }

    public class SysInfo
    {
        public static void Main()
        {
            Win32Api.SYSTEM_INFO info = new Win32Api.SYSTEM_INFO();
            Win32Api.GetSystemInfo(out info);
            Console.WriteLine("Маска набора процессоров {0} \nДоступная память для выделения {1} \nКод процессора {2} \nMaximum Application Address {3} \nMinimum Application Address {4}" +
                "\nКоличество виртуальных ядер процессора {5} \nОперативная память {6} \nУровень архитектуры процессора {7} \nProcessorRevision {8} \nТип процессора {9}", info.ActiveProcessorMask, 
                info.AllocationGranularity, info.CpuInfo, info.MaximumApplicationAddress, info.MinimumApplicationAddress, info.NumberOfProcessors, info.PageSize, info.ProcessorLevel, info.ProcessorRevision, 
                info.ProcessorType);

            Console.ReadLine();
        }
    }
}
