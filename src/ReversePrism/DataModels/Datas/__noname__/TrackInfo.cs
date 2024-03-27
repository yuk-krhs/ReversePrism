using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 SequenceType                             00018653F780 ModelEnumType CueType CueType CueType Int32
    // 018 playerHn                                 <int> IL2CPP_TYPE_I
    // 020 TrackNo                                  000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 022 Reserved                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class TrackInfo
    {
        public uint                                     Id                                      { get; set; }
        public CueType                                  SequenceType                            { get; set; }
        public ushort                                   TrackNo                                 { get; set; }
        public ushort                                   Reserved                                { get; set; }

        public static TrackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackInfo();

            value.Id                                        = GetUInt32(new IntPtr(p + 0x010)); // 0270DAC783C8 0x10 Id                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SequenceType                              = (CueType)GetInt32(new IntPtr(p + 0x014)); // 0270DAC783E8 0x14 SequenceType                ( 00018653F780 ModelEnumType CueType CueType CueType Int32 )
            value.TrackNo                                   = GetUInt16(new IntPtr(p + 0x020)); // 0270DAC78428 0x20 TrackNo                     ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Reserved                                  = GetUInt16(new IntPtr(p + 0x022)); // 0270DAC78448 0x22 Reserved                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
