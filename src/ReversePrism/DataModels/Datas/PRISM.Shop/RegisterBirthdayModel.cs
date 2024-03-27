using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InputFieldString                         0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer
    // 018 BirthYear                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C BirthMonth                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 BirthDay                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RegisterBirthdayModel
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
            var value   = new RegisterBirthdayModel();

            value.InputFieldString                          = GetObject<StringReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringReactiveProperty.FromPointer); // 0270D5511FD0 0x10 InputFieldString            ( 0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer )
            value.BirthYear                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D5511FF0 0x18 BirthYear                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BirthMonth                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D5512010 0x1C BirthMonth                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BirthDay                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D5512030 0x20 BirthDay                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
