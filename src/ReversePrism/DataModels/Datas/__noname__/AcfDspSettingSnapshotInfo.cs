using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 NumBuses                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 NumExtendBuses                           ModelPrimitiveType sbyte sbyte sbyte SByte
    // 020 Reserved                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 BusIndexes                               ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 030 ExtendBusIndexes                         ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    public partial class AcfDspSettingSnapshotInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
        public sbyte                                    NumBuses                                { get; set; }
        public sbyte                                    NumExtendBuses                          { get; set; }
        public List<sbyte>?                             Reserved                                { get; set; }
        public List<ushort>?                            BusIndexes                              { get; set; }
        public List<ushort>?                            ExtendBusIndexes                        { get; set; }

        public static AcfDspSettingSnapshotInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AcfDspSettingSnapshotInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.NumBuses                                  = GetSByte(new IntPtr(p + 0x018)); // 0x18 NumBuses                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumExtendBuses                            = GetSByte(new IntPtr(p + 0x019)); // 0x19 NumExtendBuses              ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Reserved                                  = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Reserved                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BusIndexes                                = GetUInt16List(new IntPtr(p + 0x028)); // 0x28 BusIndexes                  ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.ExtendBusIndexes                          = GetUInt16List(new IntPtr(p + 0x030)); // 0x30 ExtendBusIndexes            ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )

            return value;
        }
    }
}
