using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 Status                                   ModelPrimitiveType string string string String
    // 020 Results                                  ModelClassListType Feature[] Feature[] List<Feature> Pointer
    // 028 Error                                    ModelPrimitiveType string string string String
    public partial class Prediction : DataModel
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
            var value   = new Prediction() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.Status                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Status                      ( ModelPrimitiveType string string string String )
            value.Results                                   = GetObjectList<Feature>(new IntPtr(p + 0x020), ReversePrism.DataModels.Feature.FromPointer); // 0x20 Results                     ( ModelClassListType Feature[] Feature[] List<Feature> Pointer )
            value.Error                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Error                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
