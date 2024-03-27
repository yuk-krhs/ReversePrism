using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _ygNode                                  <int> IL2CPP_TYPE_I
    // 018 Config                                   0001865DAD70 ModelClassType YogaConfig YogaConfig YogaConfig Pointer
    // 020 Parent                                   0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer
    // 028 Children                                 000185D1E1A8 ModelClassListType List`1<YogaNode> List`1<YogaNode> List<YogaNode> Pointer
    // 030 MeasureFunction                          0001865E67D0 ModelClassType MeasureFunction MeasureFunction MeasureFunction Pointer
    // 038 BaselineFunction                         000186746890 ModelClassType BaselineFunction BaselineFunction BaselineFunction Pointer
    // 040 _data                                    <object> IL2CPP_TYPE_OBJECT
    public partial class YogaNode
    {
        public YogaConfig?                              Config                                  { get; set; }
        public WeakReference?                           Parent                                  { get; set; }
        public List<YogaNode>?                          Children                                { get; set; }
        public MeasureFunction?                         MeasureFunction                         { get; set; }
        public BaselineFunction?                        BaselineFunction                        { get; set; }

        public static YogaNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YogaNode();

            value.Config                                    = GetObject<YogaConfig>(new IntPtr(p + 0x018), ReversePrism.DataModels.YogaConfig.FromPointer); // 0270066DDA58 0x18 Config                      ( 0001865DAD70 ModelClassType YogaConfig YogaConfig YogaConfig Pointer )
            value.Parent                                    = GetObject<WeakReference>(new IntPtr(p + 0x020), ReversePrism.DataModels.WeakReference.FromPointer); // 0270066DDA78 0x20 Parent                      ( 0001866B4810 ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.Children                                  = GetObjectList<YogaNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.YogaNode.FromPointer); // 0270066DDA98 0x28 Children                    ( 000185D1E1A8 ModelClassListType List`1<YogaNode> List`1<YogaNode> List<YogaNode> Pointer )
            value.MeasureFunction                           = GetObject<MeasureFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.MeasureFunction.FromPointer); // 0270066DDAB8 0x30 MeasureFunction             ( 0001865E67D0 ModelClassType MeasureFunction MeasureFunction MeasureFunction Pointer )
            value.BaselineFunction                          = GetObject<BaselineFunction>(new IntPtr(p + 0x038), ReversePrism.DataModels.BaselineFunction.FromPointer); // 0270066DDAD8 0x38 BaselineFunction            ( 000186746890 ModelClassType BaselineFunction BaselineFunction BaselineFunction Pointer )

            return value;
        }
    }
}
