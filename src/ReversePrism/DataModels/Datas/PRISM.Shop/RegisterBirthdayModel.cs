using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InputFieldString                         ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer
    // 018 BirthYear                                ModelPrimitiveType int int int Int32
    // 01C BirthMonth                               ModelPrimitiveType int int int Int32
    // 020 BirthDay                                 ModelPrimitiveType int int int Int32
    public partial class RegisterBirthdayModel : DataModel
    {
        public StringReactiveProperty?                  InputFieldString                        { get; set; }
        public int                                      BirthYear                               { get; set; }
        public int                                      BirthMonth                              { get; set; }
        public int                                      BirthDay                                { get; set; }

        public static RegisterBirthdayModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthdayModel() { Pointer= p0 };

            value.InputFieldString                          = GetObject<StringReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringReactiveProperty.FromPointer); // 0x10 InputFieldString            ( ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer )
            value.BirthYear                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 BirthYear                   ( ModelPrimitiveType int int int Int32 )
            value.BirthMonth                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C BirthMonth                  ( ModelPrimitiveType int int int Int32 )
            value.BirthDay                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 BirthDay                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
