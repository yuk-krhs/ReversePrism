using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TmpLinkIdList                            000185D11F18 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    public partial class EfficacyDetailListPopupViewModel
    {
        public List<int>?                               TmpLinkIdList                           { get; set; }

        public static EfficacyDetailListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EfficacyDetailListPopupViewModel();

            value.TmpLinkIdList                             = GetInt32List(new IntPtr(p + 0x010)); // 0270D61D83D8 0x10 TmpLinkIdList               ( 000185D11F18 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )

            return value;
        }
    }
}
