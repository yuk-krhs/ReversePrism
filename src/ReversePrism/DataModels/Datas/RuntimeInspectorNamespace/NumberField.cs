using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 supportedTypes                           HashSet`1<Type> IL2CPP_TYPE_GENERICINST
    // 080 Input                                    00018676E9C0 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 088 NumberHandler                            0001865C4590 ModelClassType INumberHandler INumberHandler INumberHandler Pointer
    public partial class NumberField
    {
        public BoundInputField?                         Input                                   { get; set; }
        public INumberHandler?                          NumberHandler                           { get; set; }

        public static NumberField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumberField();

            value.Input                                     = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1E7A98 0x80 Input                       ( 00018676E9C0 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.NumberHandler                             = GetObject<INumberHandler>(new IntPtr(p + 0x088), ReversePrism.DataModels.INumberHandler.FromPointer); // 0270DB1E7AB8 0x88 NumberHandler               ( 0001865C4590 ModelClassType INumberHandler INumberHandler INumberHandler Pointer )

            return value;
        }
    }
}
