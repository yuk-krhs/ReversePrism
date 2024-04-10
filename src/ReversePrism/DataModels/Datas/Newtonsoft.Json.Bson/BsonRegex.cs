using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Pattern                                  0001867776E0 ModelClassType BsonString BsonString BsonString Pointer
    // 028 Options                                  0001867776E0 ModelClassType BsonString BsonString BsonString Pointer
    public partial class BsonRegex : DataModel
    {
        public BsonString?                              Pattern                                 { get; set; }
        public BsonString?                              Options                                 { get; set; }

        public static BsonRegex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonRegex() { Pointer= p0 };

            value.Pattern                                   = GetObject<BsonString>(new IntPtr(p + 0x020), ReversePrism.DataModels.BsonString.FromPointer); // 0246688F7388 0x20 Pattern                     ( 0001867776E0 ModelClassType BsonString BsonString BsonString Pointer )
            value.Options                                   = GetObject<BsonString>(new IntPtr(p + 0x028), ReversePrism.DataModels.BsonString.FromPointer); // 0246688F73A8 0x28 Options                     ( 0001867776E0 ModelClassType BsonString BsonString BsonString Pointer )

            return value;
        }
    }
}
