using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Children                                 000185CCFC58 ModelClassListType List`1<BsonToken> List`1<BsonToken> List<BsonToken> Pointer
    public partial class BsonArray
    {
        public List<BsonToken>?                         Children                                { get; set; }

        public static BsonArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonArray();

            value.Children                                  = GetObjectList<BsonToken>(new IntPtr(p + 0x020), ReversePrism.DataModels.BsonToken.FromPointer); // 0270D888DAE8 0x20 Children                    ( 000185CCFC58 ModelClassListType List`1<BsonToken> List`1<BsonToken> List<BsonToken> Pointer )

            return value;
        }
    }
}
