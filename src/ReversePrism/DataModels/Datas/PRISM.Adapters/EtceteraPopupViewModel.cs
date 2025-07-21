using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsActive                                 ModelPrimitiveType bool bool bool Bool
    // 018 CellDataList                             ModelClassListType IReadOnlyList`1<EtceteraListCellViewModel> IReadOnlyList`1<EtceteraListCellViewModel> List<EtceteraListCellViewModel> Pointer
    public partial class EtceteraPopupViewModel : DataModel
    {
        public bool                                     IsActive                                { get; set; }
        public List<EtceteraListCellViewModel>?         CellDataList                            { get; set; }

        public static EtceteraPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraPopupViewModel() { Pointer= p0 };

            value.IsActive                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsActive                    ( ModelPrimitiveType bool bool bool Bool )
            value.CellDataList                              = GetObjectList<EtceteraListCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.EtceteraListCellViewModel.FromPointer); // 0x18 CellDataList                ( ModelClassListType IReadOnlyList`1<EtceteraListCellViewModel> IReadOnlyList`1<EtceteraListCellViewModel> List<EtceteraListCellViewModel> Pointer )

            return value;
        }
    }
}
