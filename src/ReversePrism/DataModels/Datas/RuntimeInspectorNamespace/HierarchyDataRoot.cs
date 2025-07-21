using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Hierarchy                                ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    public partial class HierarchyDataRoot : DataModel
    {
        public RuntimeHierarchy?                        Hierarchy                               { get; set; }

        public static HierarchyDataRoot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDataRoot() { Pointer= p0 };

            value.Hierarchy                                 = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x030), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 0x30 Hierarchy                   ( ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )

            return value;
        }
    }
}
