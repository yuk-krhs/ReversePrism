using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Document                                 ModelClassType SymbolDocumentInfo SymbolDocumentInfo SymbolDocumentInfo Pointer
    public partial class DebugInfoExpression : DataModel
    {
        public SymbolDocumentInfo?                      Document                                { get; set; }

        public static DebugInfoExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugInfoExpression() { Pointer= p0 };

            value.Document                                  = GetObject<SymbolDocumentInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.SymbolDocumentInfo.FromPointer); // 0x10 Document                    ( ModelClassType SymbolDocumentInfo SymbolDocumentInfo SymbolDocumentInfo Pointer )

            return value;
        }
    }
}
