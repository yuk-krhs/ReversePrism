using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsCompleted                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 UnderText                                000186671910 ModelPrimitiveType string string string String
    // 020 InputText                                000186671910 ModelPrimitiveType string string string String
    // 028 CustomButtonList                         000185CD0698 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer
    // 030 IsValidName                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 IsCanceled                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 UseCancelButton                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Prefab                                   000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    public partial class UserNameInputUtility : DataModel
    {
        public bool                                     IsCompleted                             { get; set; }
        public string                                   UnderText                               { get; set; }
        public string                                   InputText                               { get; set; }
        public List<ButtonInformation>?                 CustomButtonList                        { get; set; }
        public bool                                     IsValidName                             { get; set; }
        public bool                                     IsCanceled                              { get; set; }
        public bool                                     UseCancelButton                         { get; set; }
        public PopupContentBase?                        Prefab                                  { get; set; }

        public static UserNameInputUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserNameInputUtility() { Pointer= p0 };

            value.IsCompleted                               = GetBool(new IntPtr(p + 0x010)); // 024664C771B0 0x10 IsCompleted                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnderText                                 = GetString(new IntPtr(p + 0x018)); // 024664C771D0 0x18 UnderText                   ( 000186671910 ModelPrimitiveType string string string String )
            value.InputText                                 = GetString(new IntPtr(p + 0x020)); // 024664C771F0 0x20 InputText                   ( 000186671910 ModelPrimitiveType string string string String )
            value.CustomButtonList                          = GetObjectList<ButtonInformation>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonInformation.FromPointer); // 024664C77210 0x28 CustomButtonList            ( 000185CD0698 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer )
            value.IsValidName                               = GetBool(new IntPtr(p + 0x030)); // 024664C77230 0x30 IsValidName                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsCanceled                                = GetBool(new IntPtr(p + 0x031)); // 024664C77250 0x31 IsCanceled                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseCancelButton                           = GetBool(new IntPtr(p + 0x032)); // 024664C77270 0x32 UseCancelButton             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Prefab                                    = GetObject<PopupContentBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.PopupContentBase.FromPointer); // 024664C77290 0x38 Prefab                      ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )

            return value;
        }
    }
}
