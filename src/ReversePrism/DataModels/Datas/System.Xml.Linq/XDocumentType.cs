using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 PublicId                                 ModelPrimitiveType string string string String
    // 038 SystemId                                 ModelPrimitiveType string string string String
    // 040 InternalSubset                           ModelPrimitiveType string string string String
    public partial class XDocumentType : DataModel
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
            var value   = new XDocumentType() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x030)); // 0x30 PublicId                    ( ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x038)); // 0x38 SystemId                    ( ModelPrimitiveType string string string String )
            value.InternalSubset                            = GetString(new IntPtr(p + 0x040)); // 0x40 InternalSubset              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
