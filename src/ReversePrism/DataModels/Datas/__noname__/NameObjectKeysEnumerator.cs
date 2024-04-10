using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pos                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Coll                                     00018667C030 ModelClassType NameObjectCollectionBase NameObjectCollectionBase NameObjectCollectionBase Pointer
    // 020 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Pos                                       = GetInt32(new IntPtr(p + 0x010)); // 024667BDC340 0x10 Pos                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Coll                                      = GetObject<NameObjectCollectionBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.NameObjectCollectionBase.FromPointer); // 024667BDC360 0x18 Coll                        ( 00018667C030 ModelClassType NameObjectCollectionBase NameObjectCollectionBase NameObjectCollectionBase Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 024667BDC380 0x20 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
