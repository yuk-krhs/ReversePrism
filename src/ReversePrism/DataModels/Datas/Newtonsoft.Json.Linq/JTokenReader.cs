using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Root                                     0001866005B0 ModelClassType JToken JToken JToken Pointer
    // 080 InitialPath                              000186671910 ModelPrimitiveType string string string String
    // 088 Parent                                   0001865FFEA0 ModelClassType JToken JToken JToken Pointer
    // 090 Current                                  0001865FFEA0 ModelClassType JToken JToken JToken Pointer
    public partial class JTokenReader
    {
        public JToken?                                  Root                                    { get; set; }
        public string                                   InitialPath                             { get; set; }
        public JToken?                                  Parent                                  { get; set; }
        public JToken?                                  Current                                 { get; set; }

        public static JTokenReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JTokenReader();

            value.Root                                      = GetObject<JToken>(new IntPtr(p + 0x078), ReversePrism.DataModels.JToken.FromPointer); // 0270060C4EF8 0x78 Root                        ( 0001866005B0 ModelClassType JToken JToken JToken Pointer )
            value.InitialPath                               = GetString(new IntPtr(p + 0x080)); // 0270060C4F18 0x80 InitialPath                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<JToken>(new IntPtr(p + 0x088), ReversePrism.DataModels.JToken.FromPointer); // 0270060C4F38 0x88 Parent                      ( 0001865FFEA0 ModelClassType JToken JToken JToken Pointer )
            value.Current                                   = GetObject<JToken>(new IntPtr(p + 0x090), ReversePrism.DataModels.JToken.FromPointer); // 0270060C4F58 0x90 Current                     ( 0001865FFEA0 ModelClassType JToken JToken JToken Pointer )

            return value;
        }
    }
}
