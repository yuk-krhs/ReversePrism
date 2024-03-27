using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer
    // 018 CalculatedSize                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BsonToken
    {
        public BsonToken?                               Parent                                  { get; set; }
        public int                                      CalculatedSize                          { get; set; }

        public static BsonToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonToken();

            value.Parent                                    = GetObject<BsonToken>(new IntPtr(p + 0x010), ReversePrism.DataModels.BsonToken.FromPointer); // 0270D8882CF8 0x10 Parent                      ( 000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer )
            value.CalculatedSize                            = GetInt32(new IntPtr(p + 0x018)); // 0270D8882D18 0x18 CalculatedSize              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
