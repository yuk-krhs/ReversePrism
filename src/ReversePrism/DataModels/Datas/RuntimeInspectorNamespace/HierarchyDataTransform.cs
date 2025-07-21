using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 CachedName                               ModelPrimitiveType string string string String
    // 038 Transform                                ModelClassType Transform Transform Transform Pointer
    // 040 IsSearchEntry                            ModelPrimitiveType bool bool bool Bool
    public partial class HierarchyDataTransform : DataModel
    {
        public string                                   CachedName                              { get; set; }
        public Transform?                               Transform                               { get; set; }
        public bool                                     IsSearchEntry                           { get; set; }

        public static HierarchyDataTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDataTransform() { Pointer= p0 };

            value.CachedName                                = GetString(new IntPtr(p + 0x030)); // 0x30 CachedName                  ( ModelPrimitiveType string string string String )
            value.Transform                                 = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 Transform                   ( ModelClassType Transform Transform Transform Pointer )
            value.IsSearchEntry                             = GetBool(new IntPtr(p + 0x040)); // 0x40 IsSearchEntry               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
