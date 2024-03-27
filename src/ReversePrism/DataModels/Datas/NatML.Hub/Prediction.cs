using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 Status                                   0001866722E0 ModelPrimitiveType string string string String
    // 020 Results                                  000185B7ED50 ModelClassListType Feature[] Feature[] List<Feature> Pointer
    // 028 Error                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class Prediction
    {
        public string                                   Id                                      { get; set; }
        public string                                   Status                                  { get; set; }
        public List<Feature>?                           Results                                 { get; set; }
        public string                                   Error                                   { get; set; }

        public static Prediction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Prediction();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0270DBDC00A0 0x10 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Status                                    = GetString(new IntPtr(p + 0x018)); // 0270DBDC00C0 0x18 Status                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Results                                   = GetObjectList<Feature>(new IntPtr(p + 0x020), ReversePrism.DataModels.Feature.FromPointer); // 0270DBDC00E0 0x20 Results                     ( 000185B7ED50 ModelClassListType Feature[] Feature[] List<Feature> Pointer )
            value.Error                                     = GetString(new IntPtr(p + 0x028)); // 0270DBDC0100 0x28 Error                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
