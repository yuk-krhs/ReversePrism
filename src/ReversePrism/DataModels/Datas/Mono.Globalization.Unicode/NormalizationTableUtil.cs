using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Prop                                     CodePointIndexer IL2CPP_TYPE_CLASS
    // 008 Map                                      CodePointIndexer IL2CPP_TYPE_CLASS
    // 010 Combining                                ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 018 Composite                                ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 020 Helper                                   ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    public partial class NormalizationTableUtil : DataModel
    {
        public CodePointIndexer?                        Combining                               { get; set; }
        public CodePointIndexer?                        Composite                               { get; set; }
        public CodePointIndexer?                        Helper                                  { get; set; }

        public static NormalizationTableUtil? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NormalizationTableUtil() { Pointer= p0 };

            value.Combining                                 = GetObject<CodePointIndexer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0x10 Combining                   ( ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.Composite                                 = GetObject<CodePointIndexer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0x18 Composite                   ( ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.Helper                                    = GetObject<CodePointIndexer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0x20 Helper                      ( ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )

            return value;
        }
    }
}
