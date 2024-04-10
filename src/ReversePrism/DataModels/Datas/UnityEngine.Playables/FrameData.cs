using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FrameID                                00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 M_DeltaTime                              0001865C2BA0 ModelPrimitiveType double double double Double
    // 020 M_Weight                                 000186665900 ModelPrimitiveType float float float Single
    // 024 M_EffectiveWeight                        000186665900 ModelPrimitiveType float float float Single
    // 028 M_EffectiveParentDelay                   0001865C2BA0 ModelPrimitiveType double double double Double
    // 030 M_EffectiveParentSpeed                   000186665900 ModelPrimitiveType float float float Single
    // 034 M_EffectiveSpeed                         000186665900 ModelPrimitiveType float float float Single
    // 038 M_Flags                                  0001866CB850 ModelEnumType Flags Flags Flags Int32
    // 040 M_Output                                 00018674E670 ModelEnumType PlayableOutput PlayableOutput PlayableOutput Int32
    public partial class FrameData : DataModel
    {
        public ulong                                    M_FrameID                               { get; set; }
        public double                                   M_DeltaTime                             { get; set; }
        public float                                    M_Weight                                { get; set; }
        public float                                    M_EffectiveWeight                       { get; set; }
        public double                                   M_EffectiveParentDelay                  { get; set; }
        public float                                    M_EffectiveParentSpeed                  { get; set; }
        public float                                    M_EffectiveSpeed                        { get; set; }
        public Flags                                    M_Flags                                 { get; set; }
        public PlayableOutput                           M_Output                                { get; set; }

        public static FrameData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameData() { Pointer= p0 };

            value.M_FrameID                                 = GetUInt64(new IntPtr(p + 0x010)); // 0245A6898DB8 0x10 M_FrameID                   ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_DeltaTime                               = GetDouble(new IntPtr(p + 0x018)); // 0245A6898DD8 0x18 M_DeltaTime                 ( 0001865C2BA0 ModelPrimitiveType double double double Double )
            value.M_Weight                                  = GetSingle(new IntPtr(p + 0x020)); // 0245A6898DF8 0x20 M_Weight                    ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_EffectiveWeight                         = GetSingle(new IntPtr(p + 0x024)); // 0245A6898E18 0x24 M_EffectiveWeight           ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_EffectiveParentDelay                    = GetDouble(new IntPtr(p + 0x028)); // 0245A6898E38 0x28 M_EffectiveParentDelay      ( 0001865C2BA0 ModelPrimitiveType double double double Double )
            value.M_EffectiveParentSpeed                    = GetSingle(new IntPtr(p + 0x030)); // 0245A6898E58 0x30 M_EffectiveParentSpeed      ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_EffectiveSpeed                          = GetSingle(new IntPtr(p + 0x034)); // 0245A6898E78 0x34 M_EffectiveSpeed            ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x038)); // 0245A6898E98 0x38 M_Flags                     ( 0001866CB850 ModelEnumType Flags Flags Flags Int32 )
            value.M_Output                                  = (PlayableOutput)GetInt32(new IntPtr(p + 0x040)); // 0245A6898EB8 0x40 M_Output                    ( 00018674E670 ModelEnumType PlayableOutput PlayableOutput PlayableOutput Int32 )

            return value;
        }
    }
}
