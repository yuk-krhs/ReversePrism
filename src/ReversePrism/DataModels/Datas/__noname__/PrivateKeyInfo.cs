using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  ModelPrimitiveType int int int Int32
    // 018 Algorithm                                ModelPrimitiveType string string string String
    // 020 Key                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 List                                     ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class PrivateKeyInfo : DataModel
    {
        public int                                      Version                                 { get; set; }
        public string                                   Algorithm                               { get; set; }
        public List<sbyte>?                             Key                                     { get; set; }
        public ArrayList?                               List                                    { get; set; }

        public static PrivateKeyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivateKeyInfo() { Pointer= p0 };

            value.Version                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Version                     ( ModelPrimitiveType int int int Int32 )
            value.Algorithm                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Algorithm                   ( ModelPrimitiveType string string string String )
            value.Key                                       = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Key                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0x28 List                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
