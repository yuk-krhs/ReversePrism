using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 m_ApplyStyleUpdateList                   HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 028 m_TransitionPropertyUpdateList           HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 030 M_IsApplyingStyles                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 M_Version                                000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 038 M_LastVersion                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 040 M_StyleContextHierarchyTraversal         00018652D0C0 ModelClassType VisualTreeStyleUpdaterTraversal VisualTreeStyleUpdaterTraversal VisualTreeStyleUpdaterTraversal Pointer
    // 000 s_Description                            string IL2CPP_TYPE_STRING
    // 008 s_ProfilerMarker                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 048 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class VisualTreeStyleUpdater : DataModel
    {
        public bool                                     M_IsApplyingStyles                      { get; set; }
        public uint                                     M_Version                               { get; set; }
        public uint                                     M_LastVersion                           { get; set; }
        public VisualTreeStyleUpdaterTraversal?         M_StyleContextHierarchyTraversal        { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static VisualTreeStyleUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualTreeStyleUpdater() { Pointer= p0 };

            value.M_IsApplyingStyles                        = GetBool(new IntPtr(p + 0x030)); // 0245A681FB18 0x30 M_IsApplyingStyles          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Version                                 = GetUInt32(new IntPtr(p + 0x034)); // 0245A681FB38 0x34 M_Version                   ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_LastVersion                             = GetUInt32(new IntPtr(p + 0x038)); // 0245A681FB58 0x38 M_LastVersion               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_StyleContextHierarchyTraversal          = GetObject<VisualTreeStyleUpdaterTraversal>(new IntPtr(p + 0x040), ReversePrism.DataModels.VisualTreeStyleUpdaterTraversal.FromPointer); // 0245A681FB78 0x40 M_StyleContextHierarchyTraversal ( 00018652D0C0 ModelClassType VisualTreeStyleUpdaterTraversal VisualTreeStyleUpdaterTraversal VisualTreeStyleUpdaterTraversal Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x048)); // 0245A681FBD8 0x48 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
