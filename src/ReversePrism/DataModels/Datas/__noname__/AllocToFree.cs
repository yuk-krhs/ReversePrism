using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Alloc                                    0001865866A0 ModelEnumType Alloc Alloc Alloc Int32
    // 028 Page                                     0001867144C0 ModelClassType Page Page Page Pointer
    // 030 Vertices                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class AllocToFree
    {
        public Alloc                                    Alloc                                   { get; set; }
        public Page?                                    Page                                    { get; set; }
        public bool                                     Vertices                                { get; set; }

        public static AllocToFree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllocToFree();

            value.Alloc                                     = (Alloc)GetInt32(new IntPtr(p + 0x010)); // 027006860C00 0x10 Alloc                       ( 0001865866A0 ModelEnumType Alloc Alloc Alloc Int32 )
            value.Page                                      = GetObject<Page>(new IntPtr(p + 0x028), ReversePrism.DataModels.Page.FromPointer); // 027006860C20 0x28 Page                        ( 0001867144C0 ModelClassType Page Page Page Pointer )
            value.Vertices                                  = GetBool(new IntPtr(p + 0x030)); // 027006860C40 0x30 Vertices                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
