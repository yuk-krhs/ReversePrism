using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 ProducePromotionUrl                      ModelPrimitiveType string string string String
    // 020 SortId                                   ModelPrimitiveType int int int Int32
    // 028 BannerPath                               ModelPrimitiveType string string string String
    // 030 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 EndDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstProducePromotionBanner : DataModel
    {
        public int                                      Id                                      { get; set; }
        public string                                   ProducePromotionUrl                     { get; set; }
        public int                                      SortId                                  { get; set; }
        public string                                   BannerPath                              { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static MstProducePromotionBanner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProducePromotionBanner() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.ProducePromotionUrl                       = GetString(new IntPtr(p + 0x018)); // 0x18 ProducePromotionUrl         ( ModelPrimitiveType string string string String )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.BannerPath                                = GetString(new IntPtr(p + 0x028)); // 0x28 BannerPath                  ( ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x030)); // 0x30 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 0x38 EndDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
