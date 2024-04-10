using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186674C50 ModelPrimitiveType string string string String
    // 018 NumBuses                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 NumExtendBuses                           00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 020 Reserved                                 000185B7A8C0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 BusIndexes                               000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 030 ExtendBusIndexes                         000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02466ACD7E18 0x10 Name                        ( 000186674C50 ModelPrimitiveType string string string String )
            value.NumBuses                                  = GetSByte(new IntPtr(p + 0x018)); // 02466ACD7E38 0x18 NumBuses                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumExtendBuses                            = GetSByte(new IntPtr(p + 0x019)); // 02466ACD7E58 0x19 NumExtendBuses              ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Reserved                                  = GetSByteList(new IntPtr(p + 0x020)); // 02466ACD7E78 0x20 Reserved                    ( 000185B7A8C0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BusIndexes                                = GetUInt16List(new IntPtr(p + 0x028)); // 02466ACD7E98 0x28 BusIndexes                  ( 000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.ExtendBusIndexes                          = GetUInt16List(new IntPtr(p + 0x030)); // 02466ACD7EB8 0x30 ExtendBusIndexes            ( 000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )

            return value;
        }
    }
}
