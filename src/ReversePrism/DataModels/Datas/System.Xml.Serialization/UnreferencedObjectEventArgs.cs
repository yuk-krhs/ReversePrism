using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 o                                        <object> IL2CPP_TYPE_OBJECT
    // 018 Id                                       000186671910 ModelPrimitiveType string string string String
    public partial class UnreferencedObjectEventArgs : DataModel
    {
        public string                                   Id                                      { get; set; }

        public static UnreferencedObjectEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnreferencedObjectEventArgs() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 024667506F18 0x18 Id                          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
