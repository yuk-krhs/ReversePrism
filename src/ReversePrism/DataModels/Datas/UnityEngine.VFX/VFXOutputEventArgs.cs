using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameId                                   ModelPrimitiveType int int int Int32
    // 018 EventAttribute                           ModelClassType VFXEventAttribute VFXEventAttribute VFXEventAttribute Pointer
    public partial class VFXOutputEventArgs : DataModel
    {
        public int                                      NameId                                  { get; set; }
        public VFXEventAttribute?                       EventAttribute                          { get; set; }

        public static VFXOutputEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXOutputEventArgs() { Pointer= p0 };

            value.NameId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 NameId                      ( ModelPrimitiveType int int int Int32 )
            value.EventAttribute                            = GetObject<VFXEventAttribute>(new IntPtr(p + 0x018), ReversePrism.DataModels.VFXEventAttribute.FromPointer); // 0x18 EventAttribute              ( ModelClassType VFXEventAttribute VFXEventAttribute VFXEventAttribute Pointer )

            return value;
        }
    }
}
