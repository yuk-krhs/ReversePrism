using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 inheritedData                            StyleDataRef`1<InheritedData> IL2CPP_TYPE_GENERICINST
    // 018 layoutData                               StyleDataRef`1<LayoutData> IL2CPP_TYPE_GENERICINST
    // 020 rareData                                 StyleDataRef`1<RareData> IL2CPP_TYPE_GENERICINST
    // 028 transformData                            StyleDataRef`1<TransformData> IL2CPP_TYPE_GENERICINST
    // 030 transitionData                           StyleDataRef`1<TransitionData> IL2CPP_TYPE_GENERICINST
    // 038 visualData                               StyleDataRef`1<VisualData> IL2CPP_TYPE_GENERICINST
    // 040 YogaNode                                 0001865DDF00 ModelClassType YogaNode YogaNode YogaNode Pointer
    // 048 customProperties                         Dictionary`2<string, StylePropertyValue> IL2CPP_TYPE_GENERICINST
    // 050 MatchingRulesHash                        0001865F7E40 ModelPrimitiveType long long long Int64
    // 058 DpiScaling                               000186666050 ModelPrimitiveType float float float Single
    // 060 ComputedTransitions                      000185B7BBA0 ModelEnumListType ComputedTransitionProperty[] ComputedTransitionProperty[] List<ComputedTransitionProperty> Pointer
    public partial class ComputedStyle
    {
        public YogaNode?                                YogaNode                                { get; set; }
        public long                                     MatchingRulesHash                       { get; set; }
        public float                                    DpiScaling                              { get; set; }
        public List<ComputedTransitionProperty>?        ComputedTransitions                     { get; set; }

        public static ComputedStyle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComputedStyle();

            value.YogaNode                                  = GetObject<YogaNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.YogaNode.FromPointer); // 027003F09070 0x40 YogaNode                    ( 0001865DDF00 ModelClassType YogaNode YogaNode YogaNode Pointer )
            value.MatchingRulesHash                         = GetInt64(new IntPtr(p + 0x050)); // 027003F090B0 0x50 MatchingRulesHash           ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.DpiScaling                                = GetSingle(new IntPtr(p + 0x058)); // 027003F090D0 0x58 DpiScaling                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.ComputedTransitions                       = GetEnumList<ComputedTransitionProperty>(new IntPtr(p + 0x060)); // 027003F090F0 0x60 ComputedTransitions         ( 000185B7BBA0 ModelEnumListType ComputedTransitionProperty[] ComputedTransitionProperty[] List<ComputedTransitionProperty> Pointer )

            return value;
        }
    }
}
