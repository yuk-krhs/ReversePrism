using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Invalid                                  AllocatorHandle IL2CPP_TYPE_VALUETYPE
    // 004 None                                     AllocatorHandle IL2CPP_TYPE_VALUETYPE
    // 008 Temp                                     AllocatorHandle IL2CPP_TYPE_VALUETYPE
    // 00C TempJob                                  AllocatorHandle IL2CPP_TYPE_VALUETYPE
    // 010 Persistent                               000186699E30 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 014 AudioKernel                              000186699E30 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 000 kErrorNone                               int IL2CPP_TYPE_I4
    // 000 kErrorBufferOverflow                     int IL2CPP_TYPE_I4
    // 000 FirstUserIndex                           ushort IL2CPP_TYPE_U2
    // 000 MaxNumCustomAllocators                   ushort IL2CPP_TYPE_U2
    // 018 NumGlobalScratchAllocators               000186697C20 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A MaxNumGlobalAllocators                   000186697C20 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C GlobalAllocatorBaseIndex                 00018669A3D0 ModelPrimitiveType uint uint uint UInt32
    // 020 FirstGlobalScratchpadAllocatorIndex      00018669A3D0 ModelPrimitiveType uint uint uint UInt32
    public partial class AllocatorManager
    {
        public AllocatorHandle                          Persistent                              { get; set; }
        public AllocatorHandle                          AudioKernel                             { get; set; }
        public ushort                                   NumGlobalScratchAllocators              { get; set; }
        public ushort                                   MaxNumGlobalAllocators                  { get; set; }
        public uint                                     GlobalAllocatorBaseIndex                { get; set; }
        public uint                                     FirstGlobalScratchpadAllocatorIndex     { get; set; }

        public static AllocatorManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllocatorManager();

            value.Persistent                                = (AllocatorHandle)GetInt32(new IntPtr(p + 0x010)); // 027003498FD8 0x10 Persistent                  ( 000186699E30 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.AudioKernel                               = (AllocatorHandle)GetInt32(new IntPtr(p + 0x014)); // 027003498FF8 0x14 AudioKernel                 ( 000186699E30 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.NumGlobalScratchAllocators                = GetUInt16(new IntPtr(p + 0x018)); // 027003499098 0x18 NumGlobalScratchAllocators  ( 000186697C20 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.MaxNumGlobalAllocators                    = GetUInt16(new IntPtr(p + 0x01A)); // 0270034990B8 0x1A MaxNumGlobalAllocators      ( 000186697C20 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.GlobalAllocatorBaseIndex                  = GetUInt32(new IntPtr(p + 0x01C)); // 0270034990D8 0x1C GlobalAllocatorBaseIndex    ( 00018669A3D0 ModelPrimitiveType uint uint uint UInt32 )
            value.FirstGlobalScratchpadAllocatorIndex       = GetUInt32(new IntPtr(p + 0x020)); // 0270034990F8 0x20 FirstGlobalScratchpadAllocatorIndex ( 00018669A3D0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
