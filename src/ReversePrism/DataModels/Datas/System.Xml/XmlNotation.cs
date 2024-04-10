using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PublicId                                 000186671910 ModelPrimitiveType string string string String
    // 020 SystemId                                 000186671910 ModelPrimitiveType string string string String
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class XmlNotation : DataModel
    {
        public string                                   PublicId                                { get; set; }
        public string                                   SystemId                                { get; set; }
        public string                                   Name                                    { get; set; }

        public static XmlNotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNotation() { Pointer= p0 };

            value.PublicId                                  = GetString(new IntPtr(p + 0x018)); // 0246674D1728 0x18 PublicId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x020)); // 0246674D1748 0x20 SystemId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0246674D1768 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
