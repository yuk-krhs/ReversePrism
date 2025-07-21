using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 cueName                                  <int> IL2CPP_TYPE_I
    // 018 CueNameSize                              ModelPrimitiveType uint uint uint UInt32
    // 020 Time                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 028 Tunit                                    ModelPrimitiveType ulong ulong ulong UInt64
    // 030 Type                                     ModelPrimitiveType int int int Int32
    // 038 paramString                              <int> IL2CPP_TYPE_I
    // 040 ParamStringSize                          ModelPrimitiveType uint uint uint UInt32
    // 044 CntCallback                              ModelPrimitiveType uint uint uint UInt32
    public partial class EventPoint : DataModel
    {
        public uint                                     CueNameSize                             { get; set; }
        public ulong                                    Time                                    { get; set; }
        public ulong                                    Tunit                                   { get; set; }
        public int                                      Type                                    { get; set; }
        public uint                                     ParamStringSize                         { get; set; }
        public uint                                     CntCallback                             { get; set; }

        public static EventPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventPoint() { Pointer= p0 };

            value.CueNameSize                               = GetUInt32(new IntPtr(p + 0x018)); // 0x18 CueNameSize                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.Time                                      = GetUInt64(new IntPtr(p + 0x020)); // 0x20 Time                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Tunit                                     = GetUInt64(new IntPtr(p + 0x028)); // 0x28 Tunit                       ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Type                                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 Type                        ( ModelPrimitiveType int int int Int32 )
            value.ParamStringSize                           = GetUInt32(new IntPtr(p + 0x040)); // 0x40 ParamStringSize             ( ModelPrimitiveType uint uint uint UInt32 )
            value.CntCallback                               = GetUInt32(new IntPtr(p + 0x044)); // 0x44 CntCallback                 ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
