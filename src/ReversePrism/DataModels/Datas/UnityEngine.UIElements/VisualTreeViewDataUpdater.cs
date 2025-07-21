using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 m_UpdateList                             HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 028 m_ParentList                             HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 030 M_Version                                ModelPrimitiveType uint uint uint UInt32
    // 034 M_LastVersion                            ModelPrimitiveType uint uint uint UInt32
    // 000 s_Description                            string IL2CPP_TYPE_STRING
    // 008 s_ProfilerMarker                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    public partial class VisualTreeViewDataUpdater : DataModel
    {
        public uint                                     M_Version                               { get; set; }
        public uint                                     M_LastVersion                           { get; set; }

        public static VisualTreeViewDataUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualTreeViewDataUpdater() { Pointer= p0 };

            value.M_Version                                 = GetUInt32(new IntPtr(p + 0x030)); // 0x30 M_Version                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_LastVersion                             = GetUInt32(new IntPtr(p + 0x034)); // 0x34 M_LastVersion               ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
