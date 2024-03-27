using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Children                                 000185CCF9A8 ModelClassListType List`1<BsonProperty> List`1<BsonProperty> List<BsonProperty> Pointer
    public partial class BsonObject
    {
        public List<BsonProperty>?                      Children                                { get; set; }

        public static BsonObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonObject();

            value.Children                                  = GetObjectList<BsonProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.BsonProperty.FromPointer); // 0270D8888D80 0x20 Children                    ( 000185CCF9A8 ModelClassListType List`1<BsonProperty> List`1<BsonProperty> List<BsonProperty> Pointer )

            return value;
        }
    }
}
