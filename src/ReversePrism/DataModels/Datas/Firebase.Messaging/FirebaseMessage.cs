using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SwigCPtr                                 0001866A7EC0 ModelEnumType HandleRef HandleRef HandleRef Int32
    // 020 SwigCMemOwn                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UnixEpochUtc                             DateTime IL2CPP_TYPE_VALUETYPE
    public partial class FirebaseMessage
    {
        public HandleRef                                SwigCPtr                                { get; set; }
        public bool                                     SwigCMemOwn                             { get; set; }

        public static FirebaseMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseMessage();

            value.SwigCPtr                                  = (HandleRef)GetInt32(new IntPtr(p + 0x010)); // 0270DBD838C0 0x10 SwigCPtr                    ( 0001866A7EC0 ModelEnumType HandleRef HandleRef HandleRef Int32 )
            value.SwigCMemOwn                               = GetBool(new IntPtr(p + 0x020)); // 0270DBD838E0 0x20 SwigCMemOwn                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
