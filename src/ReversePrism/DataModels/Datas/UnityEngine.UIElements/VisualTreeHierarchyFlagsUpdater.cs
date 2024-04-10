using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Version                                000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 024 M_LastVersion                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 000 s_Description                            string IL2CPP_TYPE_STRING
    // 008 s_ProfilerMarker                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    public partial class VisualTreeHierarchyFlagsUpdater : DataModel
    {
        public uint                                     M_Version                               { get; set; }
        public uint                                     M_LastVersion                           { get; set; }

        public static VisualTreeHierarchyFlagsUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualTreeHierarchyFlagsUpdater() { Pointer= p0 };

            value.M_Version                                 = GetUInt32(new IntPtr(p + 0x020)); // 0245A681F1D0 0x20 M_Version                   ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_LastVersion                             = GetUInt32(new IntPtr(p + 0x024)); // 0245A681F1F0 0x24 M_LastVersion               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
