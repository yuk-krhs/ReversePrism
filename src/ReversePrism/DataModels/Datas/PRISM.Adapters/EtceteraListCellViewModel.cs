using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsTitleCell                              ModelPrimitiveType bool bool bool Bool
    // 018 ResourceIdList                           ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    public partial class EtceteraListCellViewModel : DataModel
    {
        public bool                                     IsTitleCell                             { get; set; }
        public List<string>?                            ResourceIdList                          { get; set; }

        public static EtceteraListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraListCellViewModel() { Pointer= p0 };

            value.IsTitleCell                               = GetBool(new IntPtr(p + 0x010)); // 0x10 IsTitleCell                 ( ModelPrimitiveType bool bool bool Bool )
            value.ResourceIdList                            = GetStringList(new IntPtr(p + 0x018)); // 0x18 ResourceIdList              ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )

            return value;
        }
    }
}
