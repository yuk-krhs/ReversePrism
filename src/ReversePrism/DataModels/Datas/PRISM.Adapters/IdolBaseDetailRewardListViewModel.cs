using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewTitle                                000186672F10 ModelPrimitiveType string string string String
    // 018 CellDataList                             000185CEA778 ModelClassListType List`1<IdolBaseDetailRewardListCellData> List`1<IdolBaseDetailRewardListCellData> List<IdolBaseDetailRewardListCellData> Pointer
    public partial class IdolBaseDetailRewardListViewModel
    {
        public string                                   ViewTitle                               { get; set; }
        public List<IdolBaseDetailRewardListCellData>?  CellDataList                            { get; set; }

        public static IdolBaseDetailRewardListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailRewardListViewModel();

            value.ViewTitle                                 = GetString(new IntPtr(p + 0x010)); // 0270D5EB9718 0x10 ViewTitle                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.CellDataList                              = GetObjectList<IdolBaseDetailRewardListCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolBaseDetailRewardListCellData.FromPointer); // 0270D5EB9738 0x18 CellDataList                ( 000185CEA778 ModelClassListType List`1<IdolBaseDetailRewardListCellData> List`1<IdolBaseDetailRewardListCellData> List<IdolBaseDetailRewardListCellData> Pointer )

            return value;
        }
    }
}
