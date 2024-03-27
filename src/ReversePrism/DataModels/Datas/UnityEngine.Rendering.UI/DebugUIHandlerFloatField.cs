using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 ValueLabel                               0001866320F0 ModelClassType Text Text Text Pointer
    // 070 M_Field                                  000186585350 ModelClassType FloatField FloatField FloatField Pointer
    public partial class DebugUIHandlerFloatField
    {
        public Text?                                    NameLabel                               { get; set; }
        public Text?                                    ValueLabel                              { get; set; }
        public FloatField?                              M_Field                                 { get; set; }

        public static DebugUIHandlerFloatField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerFloatField();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270D93368D0 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueLabel                                = GetObject<Text>(new IntPtr(p + 0x068), ReversePrism.DataModels.Text.FromPointer); // 0270D93368F0 0x68 ValueLabel                  ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.M_Field                                   = GetObject<FloatField>(new IntPtr(p + 0x070), ReversePrism.DataModels.FloatField.FromPointer); // 0270D9336910 0x70 M_Field                     ( 000186585350 ModelClassType FloatField FloatField FloatField Pointer )

            return value;
        }
    }
}
