using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 040 OnListButtonClickedSubject               Subject`1<SpecialMissionListViewModel> IL2CPP_TYPE_GENERICINST
    // 048 OnUnknownButtonClickedSubject            Subject`1<SpecialMissionListViewModel> IL2CPP_TYPE_GENERICINST
    public partial class SpecialMissionListContext : DataModel
    {
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static SpecialMissionListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionListContext() { Pointer= p0 };

            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466BDDDC18 0x38 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
