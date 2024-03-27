using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SelectFavoriteMarkPopupViewFactory       000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 038 EditUnitNamePopupViewFactory             00018671C4D0 ModelClassType EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory Pointer
    // 040 FIdolDetailPopupViewFactory              000186543300 ModelClassType FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory Pointer
    // 048 PfIdolParameterDetailPopupViewFactory    0001867057D0 ModelClassType PFIdolParameterDetailPopupViewFactory PFIdolParameterDetailPopupViewFactory PFIdolParameterDetailPopupViewFactory Pointer
    public partial class ProduceResultFUnitDetailPopupViewFactory
    {
        public SelectFavoriteMarkPopupViewFactory?      SelectFavoriteMarkPopupViewFactory      { get; set; }
        public EditUnitNamePopupViewFactory?            EditUnitNamePopupViewFactory            { get; set; }
        public FIdolDetailPopupViewFactory?             FIdolDetailPopupViewFactory             { get; set; }
        public PFIdolParameterDetailPopupViewFactory?   PfIdolParameterDetailPopupViewFactory   { get; set; }

        public static ProduceResultFUnitDetailPopupViewFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultFUnitDetailPopupViewFactory();

            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 0270DA2EC318 0x30 SelectFavoriteMarkPopupViewFactory ( 000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.EditUnitNamePopupViewFactory              = GetObject<EditUnitNamePopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.EditUnitNamePopupViewFactory.FromPointer); // 0270DA2EC338 0x38 EditUnitNamePopupViewFactory ( 00018671C4D0 ModelClassType EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory Pointer )
            value.FIdolDetailPopupViewFactory               = GetObject<FIdolDetailPopupViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.FIdolDetailPopupViewFactory.FromPointer); // 0270DA2EC358 0x40 FIdolDetailPopupViewFactory ( 000186543300 ModelClassType FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory FIdolDetailPopupViewFactory Pointer )
            value.PfIdolParameterDetailPopupViewFactory     = GetObject<PFIdolParameterDetailPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.PFIdolParameterDetailPopupViewFactory.FromPointer); // 0270DA2EC378 0x48 PfIdolParameterDetailPopupViewFactory ( 0001867057D0 ModelClassType PFIdolParameterDetailPopupViewFactory PFIdolParameterDetailPopupViewFactory PFIdolParameterDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
