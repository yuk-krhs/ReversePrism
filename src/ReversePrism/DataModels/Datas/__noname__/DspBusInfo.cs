using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Volume                                   ModelPrimitiveType float float float Single
    // 01C Pan3dVolume                              ModelPrimitiveType float float float Single
    // 020 Pan3dAngle                               ModelPrimitiveType float float float Single
    // 024 Pan3dDistance                            ModelPrimitiveType float float float Single
    // 028 Pan3dSpread                              ModelPrimitiveType float float float Single
    // 030 FxIndexes                                ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 038 BusLinkIndexes                           ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 040 BusNo                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 042 NumFxes                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 043 NumBusLinks                              ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DspBusInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
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

        public static DspBusInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DspBusInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 Volume                      ( ModelPrimitiveType float float float Single )
            value.Pan3dVolume                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Pan3dVolume                 ( ModelPrimitiveType float float float Single )
            value.Pan3dAngle                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 Pan3dAngle                  ( ModelPrimitiveType float float float Single )
            value.Pan3dDistance                             = GetSingle(new IntPtr(p + 0x024)); // 0x24 Pan3dDistance               ( ModelPrimitiveType float float float Single )
            value.Pan3dSpread                               = GetSingle(new IntPtr(p + 0x028)); // 0x28 Pan3dSpread                 ( ModelPrimitiveType float float float Single )
            value.FxIndexes                                 = GetUInt16List(new IntPtr(p + 0x030)); // 0x30 FxIndexes                   ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.BusLinkIndexes                            = GetUInt16List(new IntPtr(p + 0x038)); // 0x38 BusLinkIndexes              ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.BusNo                                     = GetUInt16(new IntPtr(p + 0x040)); // 0x40 BusNo                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumFxes                                   = GetSByte(new IntPtr(p + 0x042)); // 0x42 NumFxes                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.NumBusLinks                               = GetSByte(new IntPtr(p + 0x043)); // 0x43 NumBusLinks                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
