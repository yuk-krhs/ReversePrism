using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SwigCPtr                                 0001866A7EC0 ModelEnumType HandleRef HandleRef HandleRef Int32
    // 020 SwigCMemOwn                              000186595480 ModelPrimitiveType bool bool bool Bool
    public partial class FirebaseCrashlyticsFrame
    {
        public HandleRef                                SwigCPtr                                { get; set; }
        public bool                                     SwigCMemOwn                             { get; set; }

        public static FirebaseCrashlyticsFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseCrashlyticsFrame();

            value.SwigCPtr                                  = (HandleRef)GetInt32(new IntPtr(p + 0x010)); // 0270DBC64708 0x10 SwigCPtr                    ( 0001866A7EC0 ModelEnumType HandleRef HandleRef HandleRef Int32 )
            value.SwigCMemOwn                               = GetBool(new IntPtr(p + 0x020)); // 0270DBC64728 0x20 SwigCMemOwn                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
