using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001867776E0 ModelClassType BsonString BsonString BsonString Pointer
    // 018 Value                                    000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer
    public partial class BsonProperty : DataModel
    {
        public BsonString?                              Name                                    { get; set; }
        public BsonToken?                               Value                                   { get; set; }

        public static BsonProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonProperty() { Pointer= p0 };

            value.Name                                      = GetObject<BsonString>(new IntPtr(p + 0x010), ReversePrism.DataModels.BsonString.FromPointer); // 0246688CF518 0x10 Name                        ( 0001867776E0 ModelClassType BsonString BsonString BsonString Pointer )
            value.Value                                     = GetObject<BsonToken>(new IntPtr(p + 0x018), ReversePrism.DataModels.BsonToken.FromPointer); // 0246688CF538 0x18 Value                       ( 000186777BC0 ModelClassType BsonToken BsonToken BsonToken Pointer )

            return value;
        }
    }
}
