using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FesUnitStatus                            00018650A0D0 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 018 FUnitIcon                                00018654C900 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 020 FIdolIconList                            000185CF0348 ModelClassListType IReadOnlyList`1<FIdolIcon> IReadOnlyList`1<FIdolIcon> List<FIdolIcon> Pointer
    // 028 UnitTransferProductList                  000185D07628 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 030 IdolTransferProductList                  000185D07628 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    public partial class ProduceResultTransferConfirmedPopupViewModel
    {
        public IFesUnitStatus?                          FesUnitStatus                           { get; set; }
        public FUnitIcon?                               FUnitIcon                               { get; set; }
        public List<FIdolIcon>?                         FIdolIconList                           { get; set; }
        public List<IProductWithAmountStatus>?          UnitTransferProductList                 { get; set; }
        public List<IProductWithAmountStatus>?          IdolTransferProductList                 { get; set; }

        public static ProduceResultTransferConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultTransferConfirmedPopupViewModel();

            value.FesUnitStatus                             = GetObject<IFesUnitStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0270D5F97D90 0x10 FesUnitStatus               ( 00018650A0D0 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.FUnitIcon                                 = GetObject<FUnitIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0270D5F97DB0 0x18 FUnitIcon                   ( 00018654C900 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.FIdolIconList                             = GetObjectList<FIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0270D5F97DD0 0x20 FIdolIconList               ( 000185CF0348 ModelClassListType IReadOnlyList`1<FIdolIcon> IReadOnlyList`1<FIdolIcon> List<FIdolIcon> Pointer )
            value.UnitTransferProductList                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D5F97DF0 0x28 UnitTransferProductList     ( 000185D07628 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.IdolTransferProductList                   = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D5F97E10 0x30 IdolTransferProductList     ( 000185D07628 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
