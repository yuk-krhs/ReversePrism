using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductParams                            ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer
    // 018 HaveFreeJewel                            ModelPrimitiveType long long long Int64
    // 020 HavePaidJewel                            ModelPrimitiveType long long long Int64
    // 028 PersonalLocalSave                        ModelClassType PersonalLocalSave PersonalLocalSave PersonalLocalSave Pointer
    public partial class ShopPopupModel : DataModel
    {
        public List<ShopProductParam>?                  ProductParams                           { get; set; }
        public long                                     HaveFreeJewel                           { get; set; }
        public long                                     HavePaidJewel                           { get; set; }
        public PersonalLocalSave?                       PersonalLocalSave                       { get; set; }

        public static ShopPopupModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPopupModel() { Pointer= p0 };

            value.ProductParams                             = GetObjectList<ShopProductParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0x10 ProductParams               ( ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer )
            value.HaveFreeJewel                             = GetInt64(new IntPtr(p + 0x018)); // 0x18 HaveFreeJewel               ( ModelPrimitiveType long long long Int64 )
            value.HavePaidJewel                             = GetInt64(new IntPtr(p + 0x020)); // 0x20 HavePaidJewel               ( ModelPrimitiveType long long long Int64 )
            value.PersonalLocalSave                         = GetObject<PersonalLocalSave>(new IntPtr(p + 0x028), ReversePrism.DataModels.PersonalLocalSave.FromPointer); // 0x28 PersonalLocalSave           ( ModelClassType PersonalLocalSave PersonalLocalSave PersonalLocalSave Pointer )

            return value;
        }
    }
}
