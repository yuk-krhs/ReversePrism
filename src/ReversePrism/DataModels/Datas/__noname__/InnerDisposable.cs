using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   ModelClassType RefCountDisposable RefCountDisposable RefCountDisposable Pointer
    // 018 parentLock                               <object> IL2CPP_TYPE_OBJECT
    public partial class InnerDisposable : DataModel
    {
        public RefCountDisposable?                      Parent                                  { get; set; }

        public static InnerDisposable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InnerDisposable() { Pointer= p0 };

            value.Parent                                    = GetObject<RefCountDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.RefCountDisposable.FromPointer); // 0x10 Parent                      ( ModelClassType RefCountDisposable RefCountDisposable RefCountDisposable Pointer )

            return value;
        }
    }
}
