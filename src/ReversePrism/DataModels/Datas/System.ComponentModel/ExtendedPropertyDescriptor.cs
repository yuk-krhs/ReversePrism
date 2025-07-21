using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 ExtenderInfo                             ModelClassType ReflectPropertyDescriptor ReflectPropertyDescriptor ReflectPropertyDescriptor Pointer
    // 090 Provider                                 ModelClassType IExtenderProvider IExtenderProvider IExtenderProvider Pointer
    public partial class ExtendedPropertyDescriptor : DataModel
    {
        public ReflectPropertyDescriptor?               ExtenderInfo                            { get; set; }
        public IExtenderProvider?                       Provider                                { get; set; }

        public static ExtendedPropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtendedPropertyDescriptor() { Pointer= p0 };

            value.ExtenderInfo                              = GetObject<ReflectPropertyDescriptor>(new IntPtr(p + 0x088), ReversePrism.DataModels.ReflectPropertyDescriptor.FromPointer); // 0x88 ExtenderInfo                ( ModelClassType ReflectPropertyDescriptor ReflectPropertyDescriptor ReflectPropertyDescriptor Pointer )
            value.Provider                                  = GetObject<IExtenderProvider>(new IntPtr(p + 0x090), ReversePrism.DataModels.IExtenderProvider.FromPointer); // 0x90 Provider                    ( ModelClassType IExtenderProvider IExtenderProvider IExtenderProvider Pointer )

            return value;
        }
    }
}
