using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _gate                                    <object> IL2CPP_TYPE_OBJECT
    // 018 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 020 Disposables                              ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer
    // 028 Count                                    ModelPrimitiveType int int int Int32
    // 000 SHRINK_THRESHOLD                         int IL2CPP_TYPE_I4
    public partial class CompositeDisposable : DataModel
    {
        public bool                                     Disposed                                { get; set; }
        public List<IDisposable>?                       Disposables                             { get; set; }
        public int                                      Count                                   { get; set; }

        public static CompositeDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompositeDisposable() { Pointer= p0 };

            value.Disposed                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.Disposables                               = GetObjectList<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
