using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Oids                                     0001866D8D30 ModelClassType OidCollection OidCollection OidCollection Pointer
    // 018 Current                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class OidEnumerator : DataModel
    {
        public OidCollection?                           Oids                                    { get; set; }
        public int                                      Current                                 { get; set; }

        public static OidEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OidEnumerator() { Pointer= p0 };

            value.Oids                                      = GetObject<OidCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.OidCollection.FromPointer); // 024667A39DA8 0x10 Oids                        ( 0001866D8D30 ModelClassType OidCollection OidCollection OidCollection Pointer )
            value.Current                                   = GetInt32(new IntPtr(p + 0x018)); // 024667A39DC8 0x18 Current                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
