using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 _token                                   <int> IL2CPP_TYPE_I
    // 080 Type                                     ModelPrimitiveType string string string String
    // 088 Account                                  ModelEnumType WindowsAccountType WindowsAccountType WindowsAccountType Int32
    // 08C Authenticated                            ModelPrimitiveType bool bool bool Bool
    // 090 Name                                     ModelPrimitiveType string string string String
    // 098 Info                                     ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 000 invalidWindows                           <int> IL2CPP_TYPE_I
    public partial class WindowsIdentity : DataModel
    {
        public string                                   Type                                    { get; set; }
        public WindowsAccountType                       Account                                 { get; set; }
        public bool                                     Authenticated                           { get; set; }
        public string                                   Name                                    { get; set; }
        public SerializationInfo?                       Info                                    { get; set; }

        public static WindowsIdentity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindowsIdentity() { Pointer= p0 };

            value.Type                                      = GetString(new IntPtr(p + 0x080)); // 0x80 Type                        ( ModelPrimitiveType string string string String )
            value.Account                                   = (WindowsAccountType)GetInt32(new IntPtr(p + 0x088)); // 0x88 Account                     ( ModelEnumType WindowsAccountType WindowsAccountType WindowsAccountType Int32 )
            value.Authenticated                             = GetBool(new IntPtr(p + 0x08C)); // 0x8C Authenticated               ( ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x090)); // 0x90 Name                        ( ModelPrimitiveType string string string String )
            value.Info                                      = GetObject<SerializationInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0x98 Info                        ( ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )

            return value;
        }
    }
}
