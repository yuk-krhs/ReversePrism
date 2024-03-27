using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 vertices                                 DataSet`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 020 indices                                  DataSet`1<ushort> IL2CPP_TYPE_GENERICINST
    // 028 Next                                     0001867144C0 ModelClassType Page Page Page Pointer
    // 030 FramesEmpty                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Page
    {
        public bool                                     Disposed                                { get; set; }
        public Page?                                    Next                                    { get; set; }
        public int                                      FramesEmpty                             { get; set; }

        public static Page? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Page();

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 027006862990 0x10 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Next                                      = GetObject<Page>(new IntPtr(p + 0x028), ReversePrism.DataModels.Page.FromPointer); // 0270068629F0 0x28 Next                        ( 0001867144C0 ModelClassType Page Page Page Pointer )
            value.FramesEmpty                               = GetInt32(new IntPtr(p + 0x030)); // 027006862A10 0x30 FramesEmpty                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
