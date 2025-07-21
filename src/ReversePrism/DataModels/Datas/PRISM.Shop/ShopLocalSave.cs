using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProductReadList                          ModelClassListType List`1<ProductItemReadData> List`1<ProductItemReadData> List<ProductItemReadData> Pointer
    // 028 ProductItemArray                         ModelClassListType ProductItemReadData[] ProductItemReadData[] List<ProductItemReadData> Pointer
    // 030 IsNotShowLoginPassReward                 ModelPrimitiveType bool bool bool Bool
    // 034 Year                                     ModelPrimitiveType int int int Int32
    // 038 Month                                    ModelPrimitiveType int int int Int32
    // 03C Day                                      ModelPrimitiveType int int int Int32
    // 040 PassEffectEndPULastViewedDateTime        ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class ShopLocalSave : DataModel
    {
        public List<ProductItemReadData>?               ProductReadList                         { get; set; }
        public List<ProductItemReadData>?               ProductItemArray                        { get; set; }
        public bool                                     IsNotShowLoginPassReward                { get; set; }
        public int                                      Year                                    { get; set; }
        public int                                      Month                                   { get; set; }
        public int                                      Day                                     { get; set; }
        public DateTime                                 PassEffectEndPULastViewedDateTime       { get; set; }

        public static ShopLocalSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopLocalSave() { Pointer= p0 };

            value.ProductReadList                           = GetObjectList<ProductItemReadData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductItemReadData.FromPointer); // 0x20 ProductReadList             ( ModelClassListType List`1<ProductItemReadData> List`1<ProductItemReadData> List<ProductItemReadData> Pointer )
            value.ProductItemArray                          = GetObjectList<ProductItemReadData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductItemReadData.FromPointer); // 0x28 ProductItemArray            ( ModelClassListType ProductItemReadData[] ProductItemReadData[] List<ProductItemReadData> Pointer )
            value.IsNotShowLoginPassReward                  = GetBool(new IntPtr(p + 0x030)); // 0x30 IsNotShowLoginPassReward    ( ModelPrimitiveType bool bool bool Bool )
            value.Year                                      = GetInt32(new IntPtr(p + 0x034)); // 0x34 Year                        ( ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x038)); // 0x38 Month                       ( ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Day                         ( ModelPrimitiveType int int int Int32 )
            value.PassEffectEndPULastViewedDateTime         = GetDateTime(new IntPtr(p + 0x040)); // 0x40 PassEffectEndPULastViewedDateTime ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
