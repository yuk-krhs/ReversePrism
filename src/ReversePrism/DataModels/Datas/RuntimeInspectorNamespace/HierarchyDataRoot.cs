using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Hierarchy                                000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    public partial class HierarchyDataRoot
    {
        public RuntimeHierarchy?                        Hierarchy                               { get; set; }

        public static HierarchyDataRoot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDataRoot();

            value.Hierarchy                                 = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x030), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 0270DB19C4D0 0x30 Hierarchy                   ( 000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )

            return value;
        }
    }
}
