using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Heads                                    ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer
    // 018 Tails                                    ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer
    // 020 MinDepths                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 MaxDepths                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 DirtyID                                  ModelPrimitiveType uint uint uint UInt32
    public partial class DepthOrderedDirtyTracking : DataModel
    {
        public List<VisualElement>?                     Heads                                   { get; set; }
        public List<VisualElement>?                     Tails                                   { get; set; }
        public List<int>?                               MinDepths                               { get; set; }
        public List<int>?                               MaxDepths                               { get; set; }
        public uint                                     DirtyID                                 { get; set; }

        public static DepthOrderedDirtyTracking? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOrderedDirtyTracking() { Pointer= p0 };

            value.Heads                                     = GetObjectList<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 Heads                       ( ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer )
            value.Tails                                     = GetObjectList<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0x18 Tails                       ( ModelClassListType List`1<VisualElement> List`1<VisualElement> List<VisualElement> Pointer )
            value.MinDepths                                 = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MinDepths                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MaxDepths                                 = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MaxDepths                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.DirtyID                                   = GetUInt32(new IntPtr(p + 0x030)); // 0x30 DirtyID                     ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
