using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType BsonType BsonType BsonType Int32
    // 014 Length                                   ModelPrimitiveType int int int Int32
    // 018 Position                                 ModelPrimitiveType int int int Int32
    public partial class ContainerContext : DataModel
    {
        public BsonType                                 Type                                    { get; set; }
        public int                                      Length                                  { get; set; }
        public int                                      Position                                { get; set; }

        public static ContainerContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContainerContext() { Pointer= p0 };

            value.Type                                      = (BsonType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType BsonType BsonType BsonType Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Length                      ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Position                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
