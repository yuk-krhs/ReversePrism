using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SwigCPtr                                 ModelEnumType HandleRef HandleRef HandleRef Int32
    // 020 SwigCMemOwn                              ModelPrimitiveType bool bool bool Bool
    public partial class FirebaseCrashlyticsFrame : DataModel
    {
        public HandleRef                                SwigCPtr                                { get; set; }
        public bool                                     SwigCMemOwn                             { get; set; }

        public static FirebaseCrashlyticsFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseCrashlyticsFrame() { Pointer= p0 };

            value.SwigCPtr                                  = (HandleRef)GetInt32(new IntPtr(p + 0x010)); // 0x10 SwigCPtr                    ( ModelEnumType HandleRef HandleRef HandleRef Int32 )
            value.SwigCMemOwn                               = GetBool(new IntPtr(p + 0x020)); // 0x20 SwigCMemOwn                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
