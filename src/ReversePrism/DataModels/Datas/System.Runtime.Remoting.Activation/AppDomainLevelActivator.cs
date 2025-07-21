using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActivationUrl                            ModelPrimitiveType string string string String
    // 018 Next                                     ModelClassType IActivator IActivator IActivator Pointer
    public partial class AppDomainLevelActivator : DataModel
    {
        public string                                   ActivationUrl                           { get; set; }
        public IActivator?                              Next                                    { get; set; }

        public static AppDomainLevelActivator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppDomainLevelActivator() { Pointer= p0 };

            value.ActivationUrl                             = GetString(new IntPtr(p + 0x010)); // 0x10 ActivationUrl               ( ModelPrimitiveType string string string String )
            value.Next                                      = GetObject<IActivator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IActivator.FromPointer); // 0x18 Next                        ( ModelClassType IActivator IActivator IActivator Pointer )

            return value;
        }
    }
}
