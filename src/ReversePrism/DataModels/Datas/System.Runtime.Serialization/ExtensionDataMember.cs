using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 020 Value                                    00018674B220 ModelClassType IDataNode IDataNode IDataNode Pointer
    // 028 MemberIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExtensionDataMember
    {
        public string                                   Name                                    { get; set; }
        public string                                   Ns                                      { get; set; }
        public IDataNode?                               Value                                   { get; set; }
        public int                                      MemberIndex                             { get; set; }

        public static ExtensionDataMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionDataMember();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7D34768 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0270D7D34788 0x18 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetObject<IDataNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDataNode.FromPointer); // 0270D7D347A8 0x20 Value                       ( 00018674B220 ModelClassType IDataNode IDataNode IDataNode Pointer )
            value.MemberIndex                               = GetInt32(new IntPtr(p + 0x028)); // 0270D7D347C8 0x28 MemberIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
