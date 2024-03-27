using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Type                                     000186687B60 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 020 ParentIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SchemaDatatypeMap
    {
        public string                                   Name                                    { get; set; }
        public DatatypeImplementation?                  Type                                    { get; set; }
        public int                                      ParentIndex                             { get; set; }

        public static SchemaDatatypeMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaDatatypeMap();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7500148 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<DatatypeImplementation>(new IntPtr(p + 0x018), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0270D7500168 0x18 Type                        ( 000186687B60 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.ParentIndex                               = GetInt32(new IntPtr(p + 0x020)); // 0270D7500188 0x20 ParentIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
