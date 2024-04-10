using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186778840 ModelEnumType BsonType BsonType BsonType Int32
    // 014 Length                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Position                                 0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Type                                      = (BsonType)GetInt32(new IntPtr(p + 0x010)); // 0246688C7CF0 0x10 Type                        ( 000186778840 ModelEnumType BsonType BsonType BsonType Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x014)); // 0246688C7D10 0x14 Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x018)); // 0246688C7D30 0x18 Position                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
