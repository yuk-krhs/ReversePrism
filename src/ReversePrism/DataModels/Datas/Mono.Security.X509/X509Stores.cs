using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StorePath                                ModelPrimitiveType string string string String
    // 018 NewFormat                                ModelPrimitiveType bool bool bool Bool
    // 020 Trusted                                  ModelClassType X509Store X509Store X509Store Pointer
    public partial class X509Stores : DataModel
    {
        public string                                   StorePath                               { get; set; }
        public bool                                     NewFormat                               { get; set; }
        public X509Store?                               Trusted                                 { get; set; }

        public static X509Stores? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Stores() { Pointer= p0 };

            value.StorePath                                 = GetString(new IntPtr(p + 0x010)); // 0x10 StorePath                   ( ModelPrimitiveType string string string String )
            value.NewFormat                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 NewFormat                   ( ModelPrimitiveType bool bool bool Bool )
            value.Trusted                                   = GetObject<X509Store>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509Store.FromPointer); // 0x20 Trusted                     ( ModelClassType X509Store X509Store X509Store Pointer )

            return value;
        }
    }
}
