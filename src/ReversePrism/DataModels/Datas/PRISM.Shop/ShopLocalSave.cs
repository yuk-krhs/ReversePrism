using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProductList                              000185D2B888 ModelClassListType List`1<ProductReadData> List`1<ProductReadData> List<ProductReadData> Pointer
    // 028 ProductReadList                          000185D2B638 ModelClassListType List`1<ProductItemReadData> List`1<ProductItemReadData> List<ProductItemReadData> Pointer
    // 030 ProductArray                             000185CC2FC8 ModelClassListType ProductReadData[] ProductReadData[] List<ProductReadData> Pointer
    // 038 ProductItemArray                         000185CC2EC8 ModelClassListType ProductItemReadData[] ProductItemReadData[] List<ProductItemReadData> Pointer
    // 040 IsNotShowLoginPassReward                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 Year                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 Month                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C Day                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 PassEffectEndPULastViewedDateTime        000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class ShopLocalSave
    {
        public List<ProductReadData>?                   ProductList                             { get; set; }
        public List<ProductItemReadData>?               ProductReadList                         { get; set; }
        public List<ProductReadData>?                   ProductArray                            { get; set; }
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
            var value   = new ShopLocalSave();

            value.ProductList                               = GetObjectList<ProductReadData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductReadData.FromPointer); // 027003A7E1D8 0x20 ProductList                 ( 000185D2B888 ModelClassListType List`1<ProductReadData> List`1<ProductReadData> List<ProductReadData> Pointer )
            value.ProductReadList                           = GetObjectList<ProductItemReadData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductItemReadData.FromPointer); // 027003A7E1F8 0x28 ProductReadList             ( 000185D2B638 ModelClassListType List`1<ProductItemReadData> List`1<ProductItemReadData> List<ProductItemReadData> Pointer )
            value.ProductArray                              = GetObjectList<ProductReadData>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProductReadData.FromPointer); // 027003A7E218 0x30 ProductArray                ( 000185CC2FC8 ModelClassListType ProductReadData[] ProductReadData[] List<ProductReadData> Pointer )
            value.ProductItemArray                          = GetObjectList<ProductItemReadData>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductItemReadData.FromPointer); // 027003A7E238 0x38 ProductItemArray            ( 000185CC2EC8 ModelClassListType ProductItemReadData[] ProductItemReadData[] List<ProductItemReadData> Pointer )
            value.IsNotShowLoginPassReward                  = GetBool(new IntPtr(p + 0x040)); // 027003A7E258 0x40 IsNotShowLoginPassReward    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Year                                      = GetInt32(new IntPtr(p + 0x044)); // 027003A7E278 0x44 Year                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x048)); // 027003A7E298 0x48 Month                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x04C)); // 027003A7E2B8 0x4C Day                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PassEffectEndPULastViewedDateTime         = GetDateTime(new IntPtr(p + 0x050)); // 027003A7E2D8 0x50 PassEffectEndPULastViewedDateTime ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
