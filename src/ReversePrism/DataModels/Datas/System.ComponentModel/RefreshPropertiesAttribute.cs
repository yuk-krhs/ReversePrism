using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 All                                      RefreshPropertiesAttribute IL2CPP_TYPE_CLASS
    // 008 Repaint                                  RefreshPropertiesAttribute IL2CPP_TYPE_CLASS
    // 010 Default                                  ModelClassType RefreshPropertiesAttribute RefreshPropertiesAttribute RefreshPropertiesAttribute Pointer
    // 010 Refresh                                  ModelEnumType RefreshProperties RefreshProperties RefreshProperties Int32
    public partial class RefreshPropertiesAttribute : DataModel
    {
        public RefreshPropertiesAttribute?              Default                                 { get; set; }
        public RefreshProperties                        Refresh                                 { get; set; }

        public static RefreshPropertiesAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RefreshPropertiesAttribute() { Pointer= p0 };

            value.Default                                   = GetObject<RefreshPropertiesAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.RefreshPropertiesAttribute.FromPointer); // 0x10 Default                     ( ModelClassType RefreshPropertiesAttribute RefreshPropertiesAttribute RefreshPropertiesAttribute Pointer )
            value.Refresh                                   = (RefreshProperties)GetInt32(new IntPtr(p + 0x010)); // 0x10 Refresh                     ( ModelEnumType RefreshProperties RefreshProperties RefreshProperties Int32 )

            return value;
        }
    }
}
