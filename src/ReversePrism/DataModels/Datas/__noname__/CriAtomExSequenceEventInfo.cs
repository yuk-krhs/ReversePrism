using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 playerHn                                 <int> IL2CPP_TYPE_I
    // 020 Tag                                      000186675150 ModelPrimitiveType string string string String
    // 028 PlaybackId                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C Type                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Id                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 034 Reserved                                 000186698B70 ModelPrimitiveType uint uint uint UInt32
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

            value.Position                                  = GetUInt64(new IntPtr(p + 0x010)); // 02466AC8B170 0x10 Position                    ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Tag                                       = GetString(new IntPtr(p + 0x020)); // 02466AC8B1B0 0x20 Tag                         ( 000186675150 ModelPrimitiveType string string string String )
            value.PlaybackId                                = GetUInt32(new IntPtr(p + 0x028)); // 02466AC8B1D0 0x28 PlaybackId                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Type                                      = GetInt32(new IntPtr(p + 0x02C)); // 02466AC8B1F0 0x2C Type                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Id                                        = GetUInt32(new IntPtr(p + 0x030)); // 02466AC8B210 0x30 Id                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Reserved                                  = GetUInt32(new IntPtr(p + 0x034)); // 02466AC8B230 0x34 Reserved                    ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
