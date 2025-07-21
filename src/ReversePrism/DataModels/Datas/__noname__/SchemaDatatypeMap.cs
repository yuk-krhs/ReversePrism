using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Type                                     ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 020 ParentIndex                              ModelPrimitiveType int int int Int32
    public partial class SchemaDatatypeMap : DataModel
    {
        public string                                   Name                                    { get; set; }
        public DatatypeImplementation?                  Type                                    { get; set; }
        public int                                      ParentIndex                             { get; set; }

        public static SchemaDatatypeMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaDatatypeMap() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<DatatypeImplementation>(new IntPtr(p + 0x018), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x18 Type                        ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.ParentIndex                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 ParentIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
