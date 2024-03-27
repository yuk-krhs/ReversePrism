using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 InputValid                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 022 InputAltered                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 InputField                               0001866FF160 ModelClassType InputField InputField InputField Pointer
    // 030 InputFieldBackground                     0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 DefaultEmptyValue                        000186674520 ModelPrimitiveType string string string String
    // 040 CacheTextOnValueChange                   000186597BE0 ModelPrimitiveType bool bool bool Bool
    // 048 RecentText                               000186671910 ModelPrimitiveType string string string String
    // 050 M_skinVersion                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 M_skin                                   0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    // 060 OnValueChanged                           000186705580 ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer
    // 068 OnValueSubmitted                         000186705580 ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer
    public partial class BoundInputField
    {
        public bool                                     Initialized                             { get; set; }
        public bool                                     InputValid                              { get; set; }
        public bool                                     InputAltered                            { get; set; }
        public InputField?                              InputField                              { get; set; }
        public Image?                                   InputFieldBackground                    { get; set; }
        public string                                   DefaultEmptyValue                       { get; set; }
        public bool                                     CacheTextOnValueChange                  { get; set; }
        public string                                   RecentText                              { get; set; }
        public int                                      M_skinVersion                           { get; set; }
        public UISkin?                                  M_skin                                  { get; set; }
        public OnValueChangedDelegate?                  OnValueChanged                          { get; set; }
        public OnValueChangedDelegate?                  OnValueSubmitted                        { get; set; }

        public static BoundInputField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoundInputField();

            value.Initialized                               = GetBool(new IntPtr(p + 0x020)); // 0270DB1D6878 0x20 Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InputValid                                = GetBool(new IntPtr(p + 0x021)); // 0270DB1D6898 0x21 InputValid                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InputAltered                              = GetBool(new IntPtr(p + 0x022)); // 0270DB1D68B8 0x22 InputAltered                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InputField                                = GetObject<InputField>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputField.FromPointer); // 0270DB1D68D8 0x28 InputField                  ( 0001866FF160 ModelClassType InputField InputField InputField Pointer )
            value.InputFieldBackground                      = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270DB1D68F8 0x30 InputFieldBackground        ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.DefaultEmptyValue                         = GetString(new IntPtr(p + 0x038)); // 0270DB1D6918 0x38 DefaultEmptyValue           ( 000186674520 ModelPrimitiveType string string string String )
            value.CacheTextOnValueChange                    = GetBool(new IntPtr(p + 0x040)); // 0270DB1D6938 0x40 CacheTextOnValueChange      ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )
            value.RecentText                                = GetString(new IntPtr(p + 0x048)); // 0270DB1D6958 0x48 RecentText                  ( 000186671910 ModelPrimitiveType string string string String )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x050)); // 0270DB1D6978 0x50 M_skinVersion               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x058), ReversePrism.DataModels.UISkin.FromPointer); // 0270DB1D6998 0x58 M_skin                      ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )
            value.OnValueChanged                            = GetObject<OnValueChangedDelegate>(new IntPtr(p + 0x060), ReversePrism.DataModels.OnValueChangedDelegate.FromPointer); // 0270DB1D69B8 0x60 OnValueChanged              ( 000186705580 ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer )
            value.OnValueSubmitted                          = GetObject<OnValueChangedDelegate>(new IntPtr(p + 0x068), ReversePrism.DataModels.OnValueChangedDelegate.FromPointer); // 0270DB1D69D8 0x68 OnValueSubmitted            ( 000186705580 ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer )

            return value;
        }
    }
}
