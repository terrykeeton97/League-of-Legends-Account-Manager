using System;
using System.Runtime.InteropServices;

namespace Acccount_Manager.Classes.Data
{
    internal class Structs
    {
        [Flags]
        internal enum ProcessAccessFlags : uint
        {
            PROCESS_QUERY_INFORMATION = 0x0400,
            PROCESS_VM_READ = 0x0010
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_BASIC_INFORMATION
        {
            public IntPtr ExitStatus;
            public IntPtr PebBaseAddress;
            public IntPtr AffinityMask;
            public IntPtr BasePriority;
            public IntPtr UniqueProcessId;
            public IntPtr InheritedFromUniqueProcessId;
        }
    }
}
