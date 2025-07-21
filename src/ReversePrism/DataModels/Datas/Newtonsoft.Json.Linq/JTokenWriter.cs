using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Token                                    ModelClassType JContainer JContainer JContainer Pointer
    // 068 Parent                                   ModelClassType JContainer JContainer JContainer Pointer
    // 070 Value                                    ModelClassType JValue JValue JValue Pointer
    // 078 Current                                  ModelClassType JToken JToken JToken Pointer
    public partial class JTokenWriter : DataModel
    {
        public JContainer?                              Token                                   { get; set; }
        public JContainer?                              Parent                                  { get; set; }
        public JValue?                                  Value                                   { get; set; }
        public JToken?                                  Current                                 { get; set; }

        public static JTokenWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JTokenWriter() { Pointer= p0 };

            value.Token                                     = GetObject<JContainer>(new IntPtr(p + 0x060), ReversePrism.DataModels.JContainer.FromPointer); // 0x60 Token                       ( ModelClassType JContainer JContainer JContainer Pointer )
            value.Parent                                    = GetObject<JContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.JContainer.FromPointer); // 0x68 Parent                      ( ModelClassType JContainer JContainer JContainer Pointer )
            value.Value                                     = GetObject<JValue>(new IntPtr(p + 0x070), ReversePrism.DataModels.JValue.FromPointer); // 0x70 Value                       ( ModelClassType JValue JValue JValue Pointer )
            value.Current                                   = GetObject<JToken>(new IntPtr(p + 0x078), ReversePrism.DataModels.JToken.FromPointer); // 0x78 Current                     ( ModelClassType JToken JToken JToken Pointer )

            return value;
        }
    }
}
