using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Pool                                   ObjectPool`1<PropagationPaths> IL2CPP_TYPE_GENERICINST
    // 010 TrickleDownPath                          000185D1BC78 ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer
    // 018 TargetElements                           000185D1BC78 ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer
    // 020 BubbleUpPath                             000185D1BC78 ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer
    // 000 k_DefaultPropagationDepth                int IL2CPP_TYPE_I4
    // 000 k_DefaultTargetCount                     int IL2CPP_TYPE_I4
    public partial class PropagationPaths
    {
        public List<VisualElement>?                     TrickleDownPath                         { get; set; }
        public List<VisualElement>?                     TargetElements                          { get; set; }
        public List<VisualElement>?                     BubbleUpPath                            { get; set; }

        public static PropagationPaths? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropagationPaths();

            value.TrickleDownPath                           = GetObjectList<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067CF588 0x10 TrickleDownPath             ( 000185D1BC78 ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer )
            value.TargetElements                            = GetObjectList<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067CF5A8 0x18 TargetElements              ( 000185D1BC78 ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer )
            value.BubbleUpPath                              = GetObjectList<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067CF5C8 0x20 BubbleUpPath                ( 000185D1BC78 ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer )

            return value;
        }
    }
}
