using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Ns                                       ModelPrimitiveType string string string String
    // 020 Value                                    ModelClassType IDataNode IDataNode IDataNode Pointer
    // 028 MemberIndex                              ModelPrimitiveType int int int Int32
    public partial class ExtensionDataMember : DataModel
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
            var value   = new ExtensionDataMember() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )
            value.Value                                     = GetObject<IDataNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDataNode.FromPointer); // 0x20 Value                       ( ModelClassType IDataNode IDataNode IDataNode Pointer )
            value.MemberIndex                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 MemberIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
