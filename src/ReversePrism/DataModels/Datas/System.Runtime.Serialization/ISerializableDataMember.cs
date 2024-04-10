using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Value                                    00018674B220 ModelClassType IDataNode IDataNode IDataNode Pointer
    public partial class ISerializableDataMember : DataModel
    {
        public string                                   Name                                    { get; set; }
        public IDataNode?                               Value                                   { get; set; }

        public static ISerializableDataMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ISerializableDataMember() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024667D9FE10 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetObject<IDataNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDataNode.FromPointer); // 024667D9FE30 0x18 Value                       ( 00018674B220 ModelClassType IDataNode IDataNode IDataNode Pointer )

            return value;
        }
    }
}
