using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollectionRef                            ModelClassType VariantList VariantList VariantList Pointer
    // 018 CurrentIndex                             ModelPrimitiveType int int int Int32
    // 020 currentObject                            <object> IL2CPP_TYPE_OBJECT
    // 028 CurrentSize                              ModelPrimitiveType int int int Int32
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

            value.CollectionRef                             = GetObject<VariantList>(new IntPtr(p + 0x010), ReversePrism.DataModels.VariantList.FromPointer); // 0x10 CollectionRef               ( ModelClassType VariantList VariantList VariantList Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentIndex                ( ModelPrimitiveType int int int Int32 )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentSize                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
