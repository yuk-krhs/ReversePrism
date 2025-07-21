using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pos                                      ModelPrimitiveType int int int Int32
    // 018 Coll                                     ModelClassType NameObjectCollectionBase NameObjectCollectionBase NameObjectCollectionBase Pointer
    // 020 Version                                  ModelPrimitiveType int int int Int32
    public partial class NameObjectKeysEnumerator : DataModel
    {
        public int                                      Pos                                     { get; set; }
        public NameObjectCollectionBase?                Coll                                    { get; set; }
        public int                                      Version                                 { get; set; }

        public static NameObjectKeysEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameObjectKeysEnumerator() { Pointer= p0 };

            value.Pos                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Pos                         ( ModelPrimitiveType int int int Int32 )
            value.Coll                                      = GetObject<NameObjectCollectionBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.NameObjectCollectionBase.FromPointer); // 0x18 Coll                        ( ModelClassType NameObjectCollectionBase NameObjectCollectionBase NameObjectCollectionBase Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
