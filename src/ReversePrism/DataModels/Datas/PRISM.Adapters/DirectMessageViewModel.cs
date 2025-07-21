using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Messages                                 ModelClassListType IReadOnlyList`1<DirectMessageItemViewModel> IReadOnlyList`1<DirectMessageItemViewModel> List<DirectMessageItemViewModel> Pointer
    public partial class DirectMessageViewModel : DataModel
    {
        public List<DirectMessageItemViewModel>?        Messages                                { get; set; }

        public static DirectMessageViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageViewModel() { Pointer= p0 };

            value.Messages                                  = GetObjectList<DirectMessageItemViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.DirectMessageItemViewModel.FromPointer); // 0x10 Messages                    ( ModelClassListType IReadOnlyList`1<DirectMessageItemViewModel> IReadOnlyList`1<DirectMessageItemViewModel> List<DirectMessageItemViewModel> Pointer )

            return value;
        }
    }
}
