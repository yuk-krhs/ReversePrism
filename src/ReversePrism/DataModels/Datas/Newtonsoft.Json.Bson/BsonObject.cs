using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Children                                 ModelClassListType List`1<BsonProperty> List`1<BsonProperty> List<BsonProperty> Pointer
    public partial class BsonObject : DataModel
    {
        public List<BsonProperty>?                      Children                                { get; set; }

        public static BsonObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BsonObject() { Pointer= p0 };

            value.Children                                  = GetObjectList<BsonProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.BsonProperty.FromPointer); // 0x20 Children                    ( ModelClassListType List`1<BsonProperty> List`1<BsonProperty> List<BsonProperty> Pointer )

            return value;
        }
    }
}
