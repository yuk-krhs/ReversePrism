using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   0001866714B0 ModelClassType ResourceReader ResourceReader ResourceReader Pointer
    // 018 CurrentIsValid                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C CurrentName                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 DataPosition                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ResourceEnumerator
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
            var value   = new ResourceEnumerator();

            value.Reader                                    = GetObject<ResourceReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceReader.FromPointer); // 0270D6CE8040 0x10 Reader                      ( 0001866714B0 ModelClassType ResourceReader ResourceReader ResourceReader Pointer )
            value.CurrentIsValid                            = GetBool(new IntPtr(p + 0x018)); // 0270D6CE8060 0x18 CurrentIsValid              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentName                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D6CE8080 0x1C CurrentName                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DataPosition                              = GetInt32(new IntPtr(p + 0x020)); // 0270D6CE80A0 0x20 DataPosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
