using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeId                                   000186671910 ModelPrimitiveType string string string String
    // 018 EditorBaseTypeName                       000186672F10 ModelPrimitiveType string string string String
    // 020 EditorTypeName                           000186672F10 ModelPrimitiveType string string string String
    public partial class EditorAttribute : DataModel
    {
        public string                                   TypeId                                  { get; set; }
        public string                                   EditorBaseTypeName                      { get; set; }
        public string                                   EditorTypeName                          { get; set; }

        public static EditorAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorAttribute() { Pointer= p0 };

            value.TypeId                                    = GetString(new IntPtr(p + 0x010)); // 024667B84038 0x10 TypeId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.EditorBaseTypeName                        = GetString(new IntPtr(p + 0x018)); // 024667B84058 0x18 EditorBaseTypeName          ( 000186672F10 ModelPrimitiveType string string string String )
            value.EditorTypeName                            = GetString(new IntPtr(p + 0x020)); // 024667B84078 0x20 EditorTypeName              ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
