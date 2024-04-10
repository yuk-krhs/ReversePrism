using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               CanvasUpdateRegistry IL2CPP_TYPE_CLASS
    // 010 M_PerformingLayoutUpdate                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 M_PerformingGraphicUpdate                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_CanvasUpdateProfilerStrings            000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 m_CullingUpdateProfilerString            string IL2CPP_TYPE_STRING
    // 020 m_LayoutRebuildQueue                     IndexedSet`1<ICanvasElement> IL2CPP_TYPE_GENERICINST
    // 028 m_GraphicRebuildQueue                    IndexedSet`1<ICanvasElement> IL2CPP_TYPE_GENERICINST
    // 008 s_SortLayoutFunction                     Comparison`1<ICanvasElement> IL2CPP_TYPE_GENERICINST
    public partial class CanvasUpdateRegistry : DataModel
    {
        public bool                                     M_PerformingLayoutUpdate                { get; set; }
        public bool                                     M_PerformingGraphicUpdate               { get; set; }
        public List<string>?                            M_CanvasUpdateProfilerStrings           { get; set; }

        public static CanvasUpdateRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CanvasUpdateRegistry() { Pointer= p0 };

            value.M_PerformingLayoutUpdate                  = GetBool(new IntPtr(p + 0x010)); // 0245A399FFD8 0x10 M_PerformingLayoutUpdate    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PerformingGraphicUpdate                 = GetBool(new IntPtr(p + 0x011)); // 0245A399FFF8 0x11 M_PerformingGraphicUpdate   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CanvasUpdateProfilerStrings             = GetStringList(new IntPtr(p + 0x018)); // 0245A39A0018 0x18 M_CanvasUpdateProfilerStrings ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
