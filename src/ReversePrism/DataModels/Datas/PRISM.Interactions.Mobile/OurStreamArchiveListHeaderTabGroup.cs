using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabArray                                 ModelClassListType OurStreamArchiveListHeaderTab[] OurStreamArchiveListHeaderTab[] List<OurStreamArchiveListHeaderTab> Pointer
    // 028 onClickTabSubject                        Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 030 CurrentTabIndex                          ModelPrimitiveType int int int Int32
    public partial class OurStreamArchiveListHeaderTabGroup : DataModel
    {
        public List<OurStreamArchiveListHeaderTab>?     TabArray                                { get; set; }
        public int                                      CurrentTabIndex                         { get; set; }

        public static OurStreamArchiveListHeaderTabGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveListHeaderTabGroup() { Pointer= p0 };

            value.TabArray                                  = GetObjectList<OurStreamArchiveListHeaderTab>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamArchiveListHeaderTab.FromPointer); // 0x20 TabArray                    ( ModelClassListType OurStreamArchiveListHeaderTab[] OurStreamArchiveListHeaderTab[] List<OurStreamArchiveListHeaderTab> Pointer )
            value.CurrentTabIndex                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentTabIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
