using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rp                                       0001866208E0 ModelClassType RealProxy RealProxy RealProxy Pointer
    // 018 Class                                    00018669E1F0 ModelEnumType RuntimeRemoteClassHandle RuntimeRemoteClassHandle RuntimeRemoteClassHandle Int32
    // 020 Custom_type_info                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TransparentProxy : DataModel
    {
        public RealProxy?                               Rp                                      { get; set; }
        public RuntimeRemoteClassHandle                 Class                                   { get; set; }
        public bool                                     Custom_type_info                        { get; set; }

        public static TransparentProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransparentProxy() { Pointer= p0 };

            value.Rp                                        = GetObject<RealProxy>(new IntPtr(p + 0x010), ReversePrism.DataModels.RealProxy.FromPointer); // 024666C326B8 0x10 Rp                          ( 0001866208E0 ModelClassType RealProxy RealProxy RealProxy Pointer )
            value.Class                                     = (RuntimeRemoteClassHandle)GetInt32(new IntPtr(p + 0x018)); // 024666C326D8 0x18 Class                       ( 00018669E1F0 ModelEnumType RuntimeRemoteClassHandle RuntimeRemoteClassHandle RuntimeRemoteClassHandle Int32 )
            value.Custom_type_info                          = GetBool(new IntPtr(p + 0x020)); // 024666C326F8 0x20 Custom_type_info            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
