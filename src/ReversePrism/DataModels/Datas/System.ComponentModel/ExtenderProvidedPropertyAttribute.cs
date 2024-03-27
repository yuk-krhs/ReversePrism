using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExtenderProperty                         0001865D2D60 ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer
    // 018 Provider                                 000186770F80 ModelClassType IExtenderProvider IExtenderProvider IExtenderProvider Pointer
    // 020 ReceiverType                             000186692850 ModelClassType Type Type Type Pointer
    public partial class ExtenderProvidedPropertyAttribute
    {
        public PropertyDescriptor?                      ExtenderProperty                        { get; set; }
        public IExtenderProvider?                       Provider                                { get; set; }
        public Type?                                    ReceiverType                            { get; set; }

        public static ExtenderProvidedPropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtenderProvidedPropertyAttribute();

            value.ExtenderProperty                          = GetObject<PropertyDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.PropertyDescriptor.FromPointer); // 0270D7B1DFC0 0x10 ExtenderProperty            ( 0001865D2D60 ModelClassType PropertyDescriptor PropertyDescriptor PropertyDescriptor Pointer )
            value.Provider                                  = GetObject<IExtenderProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtenderProvider.FromPointer); // 0270D7B1DFE0 0x18 Provider                    ( 000186770F80 ModelClassType IExtenderProvider IExtenderProvider IExtenderProvider Pointer )
            value.ReceiverType                              = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D7B1E000 0x20 ReceiverType                ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
