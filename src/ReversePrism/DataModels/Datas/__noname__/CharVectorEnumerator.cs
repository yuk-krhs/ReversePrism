using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionRef                            000186596730 ModelClassType CharVector CharVector CharVector Pointer
    // 018 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 currentObject                            <object> IL2CPP_TYPE_OBJECT
    // 028 CurrentSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CharVectorEnumerator : DataModel
    {
        public CharVector?                              CollectionRef                           { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      CurrentSize                             { get; set; }

        public static CharVectorEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharVectorEnumerator() { Pointer= p0 };

            value.CollectionRef                             = GetObject<CharVector>(new IntPtr(p + 0x010), ReversePrism.DataModels.CharVector.FromPointer); // 02466B7DEB60 0x10 CollectionRef               ( 000186596730 ModelClassType CharVector CharVector CharVector Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x018)); // 02466B7DEB80 0x18 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x028)); // 02466B7DEBC0 0x28 CurrentSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
