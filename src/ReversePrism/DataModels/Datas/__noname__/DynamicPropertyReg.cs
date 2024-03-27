using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Property                                 00018675CC90 ModelClassType IDynamicProperty IDynamicProperty IDynamicProperty Pointer
    // 018 Sink                                     00018675C510 ModelClassType IDynamicMessageSink IDynamicMessageSink IDynamicMessageSink Pointer
    public partial class DynamicPropertyReg
    {
        public IDynamicProperty?                        Property                                { get; set; }
        public IDynamicMessageSink?                     Sink                                    { get; set; }

        public static DynamicPropertyReg? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicPropertyReg();

            value.Property                                  = GetObject<IDynamicProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDynamicProperty.FromPointer); // 0270D6BE35F8 0x10 Property                    ( 00018675CC90 ModelClassType IDynamicProperty IDynamicProperty IDynamicProperty Pointer )
            value.Sink                                      = GetObject<IDynamicMessageSink>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDynamicMessageSink.FromPointer); // 0270D6BE3618 0x18 Sink                        ( 00018675C510 ModelClassType IDynamicMessageSink IDynamicMessageSink IDynamicMessageSink Pointer )

            return value;
        }
    }
}
