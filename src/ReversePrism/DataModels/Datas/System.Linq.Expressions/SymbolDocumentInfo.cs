using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FileName                                 ModelPrimitiveType string string string String
    // 000 DocumentType_Text                        Guid IL2CPP_TYPE_VALUETYPE
    public partial class SymbolDocumentInfo : DataModel
    {
        public string                                   FileName                                { get; set; }

        public static SymbolDocumentInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SymbolDocumentInfo() { Pointer= p0 };

            value.FileName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 FileName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
