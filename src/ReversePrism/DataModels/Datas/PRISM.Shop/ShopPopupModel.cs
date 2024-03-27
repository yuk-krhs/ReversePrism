using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductParams                            000185D093B8 ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer
    // 018 HaveFreeJewel                            0001865F7700 ModelPrimitiveType long long long Int64
    // 020 HavePaidJewel                            0001865F7700 ModelPrimitiveType long long long Int64
    // 028 PersonalLocalSave                        000186737EF0 ModelClassType PersonalLocalSave PersonalLocalSave PersonalLocalSave Pointer
    public partial class ShopPopupModel
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
            var value   = new ShopPopupModel();

            value.ProductParams                             = GetObjectList<ShopProductParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0270D5537350 0x10 ProductParams               ( 000185D093B8 ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer )
            value.HaveFreeJewel                             = GetInt64(new IntPtr(p + 0x018)); // 0270D5537370 0x18 HaveFreeJewel               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.HavePaidJewel                             = GetInt64(new IntPtr(p + 0x020)); // 0270D5537390 0x20 HavePaidJewel               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.PersonalLocalSave                         = GetObject<PersonalLocalSave>(new IntPtr(p + 0x028), ReversePrism.DataModels.PersonalLocalSave.FromPointer); // 0270D55373B0 0x28 PersonalLocalSave           ( 000186737EF0 ModelClassType PersonalLocalSave PersonalLocalSave PersonalLocalSave Pointer )

            return value;
        }
    }
}
