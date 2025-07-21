using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Reserved0                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Reserved1                                ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Size                                     ModelPrimitiveType uint uint uint UInt32
    // 018 Ptr                                      IntPtr IL2CPP_TYPE_PTR
    public partial class ProfilerMarkerData : DataModel
    {
        public sbyte                                    Type                                    { get; set; }
        public sbyte                                    Reserved0                               { get; set; }
        public ushort                                   Reserved1                               { get; set; }
        public uint                                     Size                                    { get; set; }

        public static ProfilerMarkerData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerMarkerData() { Pointer= p0 };

            value.Type                                      = GetSByte(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Reserved0                                 = GetSByte(new IntPtr(p + 0x011)); // 0x11 Reserved0                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Reserved1                                 = GetUInt16(new IntPtr(p + 0x012)); // 0x12 Reserved1                   ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Size                        ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
