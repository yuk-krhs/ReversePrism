using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 True                                     BooleanDisposable IL2CPP_TYPE_CLASS
    // 010 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 018 Current                                  ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class MultipleAssignmentDisposable : DataModel
    {
        public IDisposable?                             Current                                 { get; set; }

        public static MultipleAssignmentDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultipleAssignmentDisposable() { Pointer= p0 };

            value.Current                                   = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Current                     ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
