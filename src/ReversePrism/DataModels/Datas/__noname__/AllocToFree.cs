using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Alloc                                    ModelEnumType Alloc Alloc Alloc Int32
    // 028 Page                                     ModelClassType Page Page Page Pointer
    // 030 Vertices                                 ModelPrimitiveType bool bool bool Bool
    public partial class AllocToFree : DataModel
    {
        public Alloc                                    Alloc                                   { get; set; }
        public Page?                                    Page                                    { get; set; }
        public bool                                     Vertices                                { get; set; }

        public static AllocToFree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllocToFree() { Pointer= p0 };

            value.Alloc                                     = (Alloc)GetInt32(new IntPtr(p + 0x010)); // 0x10 Alloc                       ( ModelEnumType Alloc Alloc Alloc Int32 )
            value.Page                                      = GetObject<Page>(new IntPtr(p + 0x028), ReversePrism.DataModels.Page.FromPointer); // 0x28 Page                        ( ModelClassType Page Page Page Pointer )
            value.Vertices                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 Vertices                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
