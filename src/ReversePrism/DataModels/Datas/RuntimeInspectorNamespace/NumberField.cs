using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 supportedTypes                           HashSet`1<Type> IL2CPP_TYPE_GENERICINST
    // 080 Input                                    ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 088 NumberHandler                            ModelClassType INumberHandler INumberHandler INumberHandler Pointer
    public partial class NumberField : DataModel
    {
        public BoundInputField?                         Input                                   { get; set; }
        public INumberHandler?                          NumberHandler                           { get; set; }

        public static NumberField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumberField() { Pointer= p0 };

            value.Input                                     = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x80 Input                       ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.NumberHandler                             = GetObject<INumberHandler>(new IntPtr(p + 0x088), ReversePrism.DataModels.INumberHandler.FromPointer); // 0x88 NumberHandler               ( ModelClassType INumberHandler INumberHandler INumberHandler Pointer )

            return value;
        }
    }
}
