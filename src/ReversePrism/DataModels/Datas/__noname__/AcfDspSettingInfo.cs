using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 BusIndexes                               ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 020 ExtendBusIndexes                         ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 028 SnapshotStartIndex                       ModelPrimitiveType ushort ushort ushort UInt16
    // 02A NumBuses                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B NumExtendBuses                           ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C NumSnapshots                             ModelPrimitiveType ushort ushort ushort UInt16
    // 02E SnapshotWorkSize                         ModelPrimitiveType ushort ushort ushort UInt16
    // 030 NumMixerAisacs                           ModelPrimitiveType ushort ushort ushort UInt16
    // 032 MixerAisacStartIndex                     ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.BusIndexes                                = GetUInt16List(new IntPtr(p + 0x018)); // 0x18 BusIndexes                  ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.ExtendBusIndexes                          = GetUInt16List(new IntPtr(p + 0x020)); // 0x20 ExtendBusIndexes            ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.SnapshotStartIndex                        = GetUInt16(new IntPtr(p + 0x028)); // 0x28 SnapshotStartIndex          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumBuses                                  = GetSByte(new IntPtr(p + 0x02A)); // 0x2A NumBuses                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumExtendBuses                            = GetSByte(new IntPtr(p + 0x02B)); // 0x2B NumExtendBuses              ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumSnapshots                              = GetUInt16(new IntPtr(p + 0x02C)); // 0x2C NumSnapshots                ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.SnapshotWorkSize                          = GetUInt16(new IntPtr(p + 0x02E)); // 0x2E SnapshotWorkSize            ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumMixerAisacs                            = GetUInt16(new IntPtr(p + 0x030)); // 0x30 NumMixerAisacs              ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.MixerAisacStartIndex                      = GetUInt16(new IntPtr(p + 0x032)); // 0x32 MixerAisacStartIndex        ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
