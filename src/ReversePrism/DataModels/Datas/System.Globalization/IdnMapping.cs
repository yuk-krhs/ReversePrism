using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Allow_unassigned                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 Use_std3                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Puny                                     0001865D9850 ModelClassType Punycode Punycode Punycode Pointer
    public partial class IdnMapping : DataModel
    {
        public bool                                     Allow_unassigned                        { get; set; }
        public bool                                     Use_std3                                { get; set; }
        public Punycode?                                Puny                                    { get; set; }

        public static IdnMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdnMapping() { Pointer= p0 };

            value.Allow_unassigned                          = GetBool(new IntPtr(p + 0x010)); // 024666D90EC0 0x10 Allow_unassigned            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Use_std3                                  = GetBool(new IntPtr(p + 0x011)); // 024666D90EE0 0x11 Use_std3                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Puny                                      = GetObject<Punycode>(new IntPtr(p + 0x018), ReversePrism.DataModels.Punycode.FromPointer); // 024666D90F00 0x18 Puny                        ( 0001865D9850 ModelClassType Punycode Punycode Punycode Pointer )

            return value;
        }
    }
}
