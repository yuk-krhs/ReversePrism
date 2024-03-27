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
    public partial class VariantList
    {
        public HandleRef                                SwigCPtr                                { get; set; }
        public bool                                     SwigCMemOwn                             { get; set; }

        public static VariantList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VariantList();

            value.SwigCPtr                                  = (HandleRef)GetInt32(new IntPtr(p + 0x010)); // 0270DB77F500 0x10 SwigCPtr                    ( 0001866A7EC0 ModelEnumType HandleRef HandleRef HandleRef Int32 )
            value.SwigCMemOwn                               = GetBool(new IntPtr(p + 0x020)); // 0270DB77F520 0x20 SwigCMemOwn                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
