using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIcons                            000185B7E8E0 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer
    // 018 Amounts                                  000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class FesUnitTransferConfirmedPopupViewModel
    {
        public List<FUnitIcon>?                         SelectedIcons                           { get; set; }
        public List<int>?                               Amounts                                 { get; set; }

        public static FesUnitTransferConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitTransferConfirmedPopupViewModel();

            value.SelectedIcons                             = GetObjectList<FUnitIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0270D5EEBA70 0x10 SelectedIcons               ( 000185B7E8E0 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.Amounts                                   = GetInt32List(new IntPtr(p + 0x018)); // 0270D5EEBA90 0x18 Amounts                     ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
