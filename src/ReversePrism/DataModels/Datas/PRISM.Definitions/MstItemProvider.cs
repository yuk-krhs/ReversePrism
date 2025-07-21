using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 ProductId                                ModelPrimitiveType string string string String
    // 020 ProviderType                             ModelPrimitiveType int int int Int32
    // 028 ProviderParameter                        ModelPrimitiveType string string string String
    // 030 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 EndDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstItemProvider : DataModel
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
            var value   = new MstItemProvider() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.ProductId                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ProductId                   ( ModelPrimitiveType string string string String )
            value.ProviderType                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 ProviderType                ( ModelPrimitiveType int int int Int32 )
            value.ProviderParameter                         = GetString(new IntPtr(p + 0x028)); // 0x28 ProviderParameter           ( ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x030)); // 0x30 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 0x38 EndDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
