using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Token                                    000186743A20 ModelClassType JContainer JContainer JContainer Pointer
    // 068 Parent                                   000186743A20 ModelClassType JContainer JContainer JContainer Pointer
    // 070 Value                                    000186749400 ModelClassType JValue JValue JValue Pointer
    // 078 Current                                  0001865FFEA0 ModelClassType JToken JToken JToken Pointer
    public partial class JTokenWriter
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
            var value   = new JTokenWriter();

            value.Token                                     = GetObject<JContainer>(new IntPtr(p + 0x060), ReversePrism.DataModels.JContainer.FromPointer); // 0270D86D1A10 0x60 Token                       ( 000186743A20 ModelClassType JContainer JContainer JContainer Pointer )
            value.Parent                                    = GetObject<JContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.JContainer.FromPointer); // 0270D86D1A30 0x68 Parent                      ( 000186743A20 ModelClassType JContainer JContainer JContainer Pointer )
            value.Value                                     = GetObject<JValue>(new IntPtr(p + 0x070), ReversePrism.DataModels.JValue.FromPointer); // 0270D86D1A50 0x70 Value                       ( 000186749400 ModelClassType JValue JValue JValue Pointer )
            value.Current                                   = GetObject<JToken>(new IntPtr(p + 0x078), ReversePrism.DataModels.JToken.FromPointer); // 0270D86D1A70 0x78 Current                     ( 0001865FFEA0 ModelClassType JToken JToken JToken Pointer )

            return value;
        }
    }
}
