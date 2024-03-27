using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 030 PublicId                                 000186671910 ModelPrimitiveType string string string String
    // 038 SystemId                                 000186671910 ModelPrimitiveType string string string String
    // 040 InternalSubset                           000186671910 ModelPrimitiveType string string string String
    public partial class XDocumentType
    {
        public string                                   Name                                    { get; set; }
        public string                                   PublicId                                { get; set; }
        public string                                   SystemId                                { get; set; }
        public string                                   InternalSubset                          { get; set; }

        public static XDocumentType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XDocumentType();

            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D886E108 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x030)); // 0270D886E128 0x30 PublicId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x038)); // 0270D886E148 0x38 SystemId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.InternalSubset                            = GetString(new IntPtr(p + 0x040)); // 0270D886E168 0x40 InternalSubset              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
