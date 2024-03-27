using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 psUnrestricted                           <object>[] IL2CPP_TYPE_SZARRAY
    // 010 State                                    000186735B00 ModelEnumType PermissionState PermissionState PermissionState Int32
    // 018 List                                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 Declsec                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Ignored                                  000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 008 action                                   <object>[] IL2CPP_TYPE_SZARRAY
    public partial class PermissionSet
    {
        public PermissionState                          State                                   { get; set; }
        public ArrayList?                               List                                    { get; set; }
        public bool                                     Declsec                                 { get; set; }
        public List<bool>?                              Ignored                                 { get; set; }

        public static PermissionSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PermissionSet();

            value.State                                     = (PermissionState)GetInt32(new IntPtr(p + 0x010)); // 0270D6B68B30 0x10 State                       ( 000186735B00 ModelEnumType PermissionState PermissionState PermissionState Int32 )
            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D6B68B50 0x18 List                        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Declsec                                   = GetBool(new IntPtr(p + 0x020)); // 0270D6B68B70 0x20 Declsec                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ignored                                   = GetBoolList(new IntPtr(p + 0x028)); // 0270D6B68B90 0x28 Ignored                     ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
