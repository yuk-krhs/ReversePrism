using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Ignorable                                CodePointIndexer IL2CPP_TYPE_CLASS
    // 008 Category                                 CodePointIndexer IL2CPP_TYPE_CLASS
    // 010 Level1                                   0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 018 Level2                                   0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 020 Level3                                   0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 028 CjkCHS                                   0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 030 Cjk                                      0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    public partial class MSCompatUnicodeTableUtil : DataModel
    {
        public CodePointIndexer?                        Level1                                  { get; set; }
        public CodePointIndexer?                        Level2                                  { get; set; }
        public CodePointIndexer?                        Level3                                  { get; set; }
        public CodePointIndexer?                        CjkCHS                                  { get; set; }
        public CodePointIndexer?                        Cjk                                     { get; set; }

        public static MSCompatUnicodeTableUtil? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MSCompatUnicodeTableUtil() { Pointer= p0 };

            value.Level1                                    = GetObject<CodePointIndexer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0245A3CE31C0 0x10 Level1                      ( 0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.Level2                                    = GetObject<CodePointIndexer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0245A3CE31E0 0x18 Level2                      ( 0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.Level3                                    = GetObject<CodePointIndexer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0245A3CE3200 0x20 Level3                      ( 0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.CjkCHS                                    = GetObject<CodePointIndexer>(new IntPtr(p + 0x028), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0245A3CE3220 0x28 CjkCHS                      ( 0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.Cjk                                       = GetObject<CodePointIndexer>(new IntPtr(p + 0x030), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0245A3CE3240 0x30 Cjk                         ( 0001865A98F0 ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )

            return value;
        }
    }
}
