using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsTitleCell                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 ResourceIdList                           000185D17078 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    public partial class EtceteraListCellViewModel
    {
        public bool                                     IsTitleCell                             { get; set; }
        public List<string>?                            ResourceIdList                          { get; set; }

        public static EtceteraListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraListCellViewModel();

            value.IsTitleCell                               = GetBool(new IntPtr(p + 0x010)); // 0270D5F2D1C8 0x10 IsTitleCell                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ResourceIdList                            = GetStringList(new IntPtr(p + 0x018)); // 0270D5F2D1E8 0x18 ResourceIdList              ( 000185D17078 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )

            return value;
        }
    }
}
