using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ResourceTag                              ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class IntroductionUnitSelectCellListContext : DataModel
    {
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static IntroductionUnitSelectCellListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitSelectCellListContext() { Pointer= p0 };

            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 0x40 ResourceTag                 ( ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
