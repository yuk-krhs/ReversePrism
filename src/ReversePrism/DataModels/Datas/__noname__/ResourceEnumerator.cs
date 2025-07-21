using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   ModelClassType ResourceReader ResourceReader ResourceReader Pointer
    // 018 CurrentIsValid                           ModelPrimitiveType bool bool bool Bool
    // 01C CurrentName                              ModelPrimitiveType int int int Int32
    // 020 DataPosition                             ModelPrimitiveType int int int Int32
    public partial class ResourceEnumerator : DataModel
    {
        public ResourceReader?                          Reader                                  { get; set; }
        public bool                                     CurrentIsValid                          { get; set; }
        public int                                      CurrentName                             { get; set; }
        public int                                      DataPosition                            { get; set; }

        public static ResourceEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceEnumerator() { Pointer= p0 };

            value.Reader                                    = GetObject<ResourceReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceReader.FromPointer); // 0x10 Reader                      ( ModelClassType ResourceReader ResourceReader ResourceReader Pointer )
            value.CurrentIsValid                            = GetBool(new IntPtr(p + 0x018)); // 0x18 CurrentIsValid              ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentName                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurrentName                 ( ModelPrimitiveType int int int Int32 )
            value.DataPosition                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 DataPosition                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
