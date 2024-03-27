using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ProductId                                000186672F10 ModelPrimitiveType string string string String
    // 020 ProviderType                             0001865F4260 ModelPrimitiveType int int int Int32
    // 028 ProviderParameter                        000186672F10 ModelPrimitiveType string string string String
    // 030 BeginDate                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 EndDate                                  0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstItemProvider
    {
        public int                                      Id                                      { get; set; }
        public string                                   ProductId                               { get; set; }
        public int                                      ProviderType                            { get; set; }
        public string                                   ProviderParameter                       { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static MstItemProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstItemProvider();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045945F8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ProductId                                 = GetString(new IntPtr(p + 0x018)); // 027004594618 0x18 ProductId                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.ProviderType                              = GetInt32(new IntPtr(p + 0x020)); // 027004594638 0x20 ProviderType                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ProviderParameter                         = GetString(new IntPtr(p + 0x028)); // 027004594658 0x28 ProviderParameter           ( 000186672F10 ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x030)); // 027004594678 0x30 BeginDate                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 027004594698 0x38 EndDate                     ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
