using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIcons                            000185B7E550 ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer
    // 018 Amounts                                  000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class FesIdolTransferConfirmedPopupViewModel : DataModel
    {
        public List<FIdolIcon>?                         SelectedIcons                           { get; set; }
        public List<int>?                               Amounts                                 { get; set; }

        public static FesIdolTransferConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolTransferConfirmedPopupViewModel() { Pointer= p0 };

            value.SelectedIcons                             = GetObjectList<FIdolIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.FIdolIcon.FromPointer); // 024665F4C488 0x10 SelectedIcons               ( 000185B7E550 ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer )
            value.Amounts                                   = GetInt32List(new IntPtr(p + 0x018)); // 024665F4C4A8 0x18 Amounts                     ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
