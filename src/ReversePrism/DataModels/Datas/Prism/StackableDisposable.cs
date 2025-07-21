using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseDisposable                           ModelClassType IDisposable IDisposable IDisposable Pointer
    // 018 Count                                    ModelPrimitiveType int int int Int32
    public partial class StackableDisposable : DataModel
    {
        public IDisposable?                             BaseDisposable                          { get; set; }
        public int                                      Count                                   { get; set; }

        public static StackableDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackableDisposable() { Pointer= p0 };

            value.BaseDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDisposable.FromPointer); // 0x10 BaseDisposable              ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
