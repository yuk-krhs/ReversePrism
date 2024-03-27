using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 018 ReferenceCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MaterialEntry
    {
        public Material?                                Material                                { get; set; }
        public int                                      ReferenceCount                          { get; set; }

        public static MaterialEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaterialEntry();

            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0270DBDF3720 0x10 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x018)); // 0270DBDF3740 0x18 ReferenceCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
