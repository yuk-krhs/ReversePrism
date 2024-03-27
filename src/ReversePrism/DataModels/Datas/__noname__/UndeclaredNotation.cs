using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 018 LineNo                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C LinePos                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Next                                     0001865C57B0 ModelClassType UndeclaredNotation UndeclaredNotation UndeclaredNotation Pointer
    public partial class UndeclaredNotation
    {
        public string                                   Name                                    { get; set; }
        public int                                      LineNo                                  { get; set; }
        public int                                      LinePos                                 { get; set; }
        public UndeclaredNotation?                      Next                                    { get; set; }

        public static UndeclaredNotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UndeclaredNotation();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7476B40 0x10 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.LineNo                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D7476B60 0x18 LineNo                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x01C)); // 0270D7476B80 0x1C LinePos                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<UndeclaredNotation>(new IntPtr(p + 0x020), ReversePrism.DataModels.UndeclaredNotation.FromPointer); // 0270D7476BA0 0x20 Next                        ( 0001865C57B0 ModelClassType UndeclaredNotation UndeclaredNotation UndeclaredNotation Pointer )

            return value;
        }
    }
}
