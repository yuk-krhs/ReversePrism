using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Writer                                   000186775B20 ModelClassType BsonBinaryWriter BsonBinaryWriter BsonBinaryWriter Pointer
    // 068 Root                                     000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer
    // 070 Parent                                   000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer
    // 078 PropertyName                             000186671910 ModelPrimitiveType string string string String
    public partial class BsonWriter : DataModel
    {
        public BsonBinaryWriter?                        Writer                                  { get; set; }
        public BsonToken?                               Root                                    { get; set; }
        public BsonToken?                               Parent                                  { get; set; }
        public string                                   PropertyName                            { get; set; }

        public static BsonWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonWriter() { Pointer= p0 };

            value.Writer                                    = GetObject<BsonBinaryWriter>(new IntPtr(p + 0x060), ReversePrism.DataModels.BsonBinaryWriter.FromPointer); // 0246688AE4A0 0x60 Writer                      ( 000186775B20 ModelClassType BsonBinaryWriter BsonBinaryWriter BsonBinaryWriter Pointer )
            value.Root                                      = GetObject<BsonToken>(new IntPtr(p + 0x068), ReversePrism.DataModels.BsonToken.FromPointer); // 0246688AE4C0 0x68 Root                        ( 000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer )
            value.Parent                                    = GetObject<BsonToken>(new IntPtr(p + 0x070), ReversePrism.DataModels.BsonToken.FromPointer); // 0246688AE4E0 0x70 Parent                      ( 000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer )
            value.PropertyName                              = GetString(new IntPtr(p + 0x078)); // 0246688AE500 0x78 PropertyName                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
