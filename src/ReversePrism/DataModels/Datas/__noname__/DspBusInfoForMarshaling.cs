using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 namePtr                                  <int> IL2CPP_TYPE_I
    // 018 Volume                                   000186666050 ModelPrimitiveType float float float Single
    // 01C Pan3dVolume                              000186666050 ModelPrimitiveType float float float Single
    // 020 Pan3dAngle                               000186666050 ModelPrimitiveType float float float Single
    // 024 Pan3dDistance                            000186666050 ModelPrimitiveType float float float Single
    // 028 Pan3dSpread                              000186666050 ModelPrimitiveType float float float Single
    // 030 FxIndexes                                000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 038 BusLinkIndexes                           000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 040 BusNo                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 042 NumFxes                                  00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 043 NumBusLinks                              00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DspBusInfoForMarshaling
    {
        public float                                    Volume                                  { get; set; }
        public float                                    Pan3dVolume                             { get; set; }
        public float                                    Pan3dAngle                              { get; set; }
        public float                                    Pan3dDistance                           { get; set; }
        public float                                    Pan3dSpread                             { get; set; }
        public List<ushort>?                            FxIndexes                               { get; set; }
        public List<ushort>?                            BusLinkIndexes                          { get; set; }
        public ushort                                   BusNo                                   { get; set; }
        public sbyte                                    NumFxes                                 { get; set; }
        public sbyte                                    NumBusLinks                             { get; set; }

        public static DspBusInfoForMarshaling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DspBusInfoForMarshaling();

            value.Volume                                    = GetSingle(new IntPtr(p + 0x018)); // 0270DACC22C8 0x18 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Pan3dVolume                               = GetSingle(new IntPtr(p + 0x01C)); // 0270DACC22E8 0x1C Pan3dVolume                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Pan3dAngle                                = GetSingle(new IntPtr(p + 0x020)); // 0270DACC2308 0x20 Pan3dAngle                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Pan3dDistance                             = GetSingle(new IntPtr(p + 0x024)); // 0270DACC2328 0x24 Pan3dDistance               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Pan3dSpread                               = GetSingle(new IntPtr(p + 0x028)); // 0270DACC2348 0x28 Pan3dSpread                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.FxIndexes                                 = GetUInt16List(new IntPtr(p + 0x030)); // 0270DACC2368 0x30 FxIndexes                   ( 000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.BusLinkIndexes                            = GetUInt16List(new IntPtr(p + 0x038)); // 0270DACC2388 0x38 BusLinkIndexes              ( 000185CAEF38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.BusNo                                     = GetUInt16(new IntPtr(p + 0x040)); // 0270DACC23A8 0x40 BusNo                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumFxes                                   = GetSByte(new IntPtr(p + 0x042)); // 0270DACC23C8 0x42 NumFxes                     ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumBusLinks                               = GetSByte(new IntPtr(p + 0x043)); // 0270DACC23E8 0x43 NumBusLinks                 ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
