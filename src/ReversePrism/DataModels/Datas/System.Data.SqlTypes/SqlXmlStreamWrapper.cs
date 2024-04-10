using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 030 LPosition                                0001865F7700 ModelPrimitiveType long long long Int64
    // 038 IsClosed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SqlXmlStreamWrapper : DataModel
    {
        public Stream?                                  Stream                                  { get; set; }
        public long                                     LPosition                               { get; set; }
        public bool                                     IsClosed                                { get; set; }

        public static SqlXmlStreamWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlXmlStreamWrapper() { Pointer= p0 };

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 024668A10670 0x28 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.LPosition                                 = GetInt64(new IntPtr(p + 0x030)); // 024668A10690 0x30 LPosition                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IsClosed                                  = GetBool(new IntPtr(p + 0x038)); // 024668A106B0 0x38 IsClosed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
