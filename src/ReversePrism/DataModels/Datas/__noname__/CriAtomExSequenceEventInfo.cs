using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 playerHn                                 <int> IL2CPP_TYPE_I
    // 020 Tag                                      ModelPrimitiveType string string string String
    // 028 PlaybackId                               ModelPrimitiveType uint uint uint UInt32
    // 02C Type                                     ModelPrimitiveType int int int Int32
    // 030 Id                                       ModelPrimitiveType uint uint uint UInt32
    // 034 Reserved                                 ModelPrimitiveType uint uint uint UInt32
    public partial class CriAtomExSequenceEventInfo : DataModel
    {
        public ulong                                    Position                                { get; set; }
        public string                                   Tag                                     { get; set; }
        public uint                                     PlaybackId                              { get; set; }
        public int                                      Type                                    { get; set; }
        public uint                                     Id                                      { get; set; }
        public uint                                     Reserved                                { get; set; }

        public static CriAtomExSequenceEventInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExSequenceEventInfo() { Pointer= p0 };

            value.Position                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Tag                                       = GetString(new IntPtr(p + 0x020)); // 0x20 Tag                         ( ModelPrimitiveType string string string String )
            value.PlaybackId                                = GetUInt32(new IntPtr(p + 0x028)); // 0x28 PlaybackId                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.Type                                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Type                        ( ModelPrimitiveType int int int Int32 )
            value.Id                                        = GetUInt32(new IntPtr(p + 0x030)); // 0x30 Id                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.Reserved                                  = GetUInt32(new IntPtr(p + 0x034)); // 0x34 Reserved                    ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
