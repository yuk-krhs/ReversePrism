using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisposedCallCount                        ModelPrimitiveType int int int Int32
    // 018 Disposables                              ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer
    public partial class NAry : DataModel
    {
        public int                                      DisposedCallCount                       { get; set; }
        public List<IDisposable>?                       Disposables                             { get; set; }

        public static NAry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NAry() { Pointer= p0 };

            value.DisposedCallCount                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 DisposedCallCount           ( ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObjectList<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer )

            return value;
        }
    }
}
