using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 030 LPosition                                ModelPrimitiveType long long long Int64
    // 038 IsClosed                                 ModelPrimitiveType bool bool bool Bool
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

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0x28 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.LPosition                                 = GetInt64(new IntPtr(p + 0x030)); // 0x30 LPosition                   ( ModelPrimitiveType long long long Int64 )
            value.IsClosed                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 IsClosed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
