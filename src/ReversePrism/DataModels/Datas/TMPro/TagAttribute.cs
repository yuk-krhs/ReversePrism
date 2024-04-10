using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Length                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 HashCode                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TagAttribute : DataModel
    {
        public int                                      StartIndex                              { get; set; }
        public int                                      Length                                  { get; set; }
        public int                                      HashCode                                { get; set; }

        public static TagAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TagAttribute() { Pointer= p0 };

            value.StartIndex                                = GetInt32(new IntPtr(p + 0x010)); // 02466A674938 0x10 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x014)); // 02466A674958 0x14 Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x018)); // 02466A674978 0x18 HashCode                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
