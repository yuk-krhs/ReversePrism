using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 LineNo                                   ModelPrimitiveType int int int Int32
    // 01C LinePos                                  ModelPrimitiveType int int int Int32
    // 020 Next                                     ModelClassType UndeclaredNotation UndeclaredNotation UndeclaredNotation Pointer
    public partial class UndeclaredNotation : DataModel
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
            var value   = new UndeclaredNotation() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.LineNo                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 LineNo                      ( ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C LinePos                     ( ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<UndeclaredNotation>(new IntPtr(p + 0x020), ReversePrism.DataModels.UndeclaredNotation.FromPointer); // 0x20 Next                        ( ModelClassType UndeclaredNotation UndeclaredNotation UndeclaredNotation Pointer )

            return value;
        }
    }
}
