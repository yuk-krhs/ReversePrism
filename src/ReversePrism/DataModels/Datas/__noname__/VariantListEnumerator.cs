using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionRef                            000186773A20 ModelClassType VariantList VariantList VariantList Pointer
    // 018 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 currentObject                            <object> IL2CPP_TYPE_OBJECT
    // 028 CurrentSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class VariantListEnumerator : DataModel
    {
        public VariantList?                             CollectionRef                           { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      CurrentSize                             { get; set; }

        public static VariantListEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VariantListEnumerator() { Pointer= p0 };

            value.CollectionRef                             = GetObject<VariantList>(new IntPtr(p + 0x010), ReversePrism.DataModels.VariantList.FromPointer); // 02466B811C68 0x10 CollectionRef               ( 000186773A20 ModelClassType VariantList VariantList VariantList Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x018)); // 02466B811C88 0x18 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x028)); // 02466B811CC8 0x28 CurrentSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
