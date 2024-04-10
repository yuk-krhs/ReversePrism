using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 onClickCellSubject                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 098 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class IntroductionUnitSelectCellList : DataModel
    {
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static IntroductionUnitSelectCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitSelectCellList() { Pointer= p0 };

            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x098), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466BCDCA88 0x98 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
