using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186674C50 ModelPrimitiveType string string string String
    // 018 BusIndexes                               000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 020 ExtendBusIndexes                         000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 028 SnapshotStartIndex                       000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02A NumBuses                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B NumExtendBuses                           00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C NumSnapshots                             000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02E SnapshotWorkSize                         000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 030 NumMixerAisacs                           000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 032 MixerAisacStartIndex                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class AcfDspSettingInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<ushort>?                            BusIndexes                              { get; set; }
        public List<ushort>?                            ExtendBusIndexes                        { get; set; }
        public ushort                                   SnapshotStartIndex                      { get; set; }
        public sbyte                                    NumBuses                                { get; set; }
        public sbyte                                    NumExtendBuses                          { get; set; }
        public ushort                                   NumSnapshots                            { get; set; }
        public ushort                                   SnapshotWorkSize                        { get; set; }
        public ushort                                   NumMixerAisacs                          { get; set; }
        public ushort                                   MixerAisacStartIndex                    { get; set; }

        public static AcfDspSettingInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AcfDspSettingInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02466ACD7C68 0x10 Name                        ( 000186674C50 ModelPrimitiveType string string string String )
            value.BusIndexes                                = GetUInt16List(new IntPtr(p + 0x018)); // 02466ACD7C88 0x18 BusIndexes                  ( 000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.ExtendBusIndexes                          = GetUInt16List(new IntPtr(p + 0x020)); // 02466ACD7CA8 0x20 ExtendBusIndexes            ( 000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.SnapshotStartIndex                        = GetUInt16(new IntPtr(p + 0x028)); // 02466ACD7CC8 0x28 SnapshotStartIndex          ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumBuses                                  = GetSByte(new IntPtr(p + 0x02A)); // 02466ACD7CE8 0x2A NumBuses                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumExtendBuses                            = GetSByte(new IntPtr(p + 0x02B)); // 02466ACD7D08 0x2B NumExtendBuses              ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumSnapshots                              = GetUInt16(new IntPtr(p + 0x02C)); // 02466ACD7D28 0x2C NumSnapshots                ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.SnapshotWorkSize                          = GetUInt16(new IntPtr(p + 0x02E)); // 02466ACD7D48 0x2E SnapshotWorkSize            ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumMixerAisacs                            = GetUInt16(new IntPtr(p + 0x030)); // 02466ACD7D68 0x30 NumMixerAisacs              ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.MixerAisacStartIndex                      = GetUInt16(new IntPtr(p + 0x032)); // 02466ACD7D88 0x32 MixerAisacStartIndex        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
