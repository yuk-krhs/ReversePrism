using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseDisposable                           000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 018 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StackableDisposable
    {
        public IDisposable?                             BaseDisposable                          { get; set; }
        public int                                      Count                                   { get; set; }

        public static StackableDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackableDisposable();

            value.BaseDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDisposable.FromPointer); // 0270041CE518 0x10 BaseDisposable              ( 000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0270041CE538 0x18 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
