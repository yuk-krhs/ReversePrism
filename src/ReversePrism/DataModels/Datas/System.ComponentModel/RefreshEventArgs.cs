using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeChanged                              0001866936B0 ModelClassType Type Type Type Pointer
    public partial class RefreshEventArgs : DataModel
    {
        public Type?                                    TypeChanged                             { get; set; }

        public static RefreshEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RefreshEventArgs() { Pointer= p0 };

            value.TypeChanged                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024667BA17A8 0x10 TypeChanged                 ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
