using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Children                                 ModelClassListType List`1<BsonToken> List`1<BsonToken> List<BsonToken> Pointer
    public partial class BsonArray : DataModel
    {
        public List<BsonToken>?                         Children                                { get; set; }

        public static BsonArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonArray() { Pointer= p0 };

            value.Children                                  = GetObjectList<BsonToken>(new IntPtr(p + 0x020), ReversePrism.DataModels.BsonToken.FromPointer); // 0x20 Children                    ( ModelClassListType List`1<BsonToken> List`1<BsonToken> List<BsonToken> Pointer )

            return value;
        }
    }
}
