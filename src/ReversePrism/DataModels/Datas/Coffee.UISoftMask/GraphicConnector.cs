using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Connectors                             List`1<GraphicConnector> IL2CPP_TYPE_GENERICINST
    // 008 s_ConnectorMap                           Dictionary`2<Type, GraphicConnector> IL2CPP_TYPE_GENERICINST
    // 010 S_EmptyConnector                         000186692F70 ModelClassType GraphicConnector GraphicConnector GraphicConnector Pointer
    public partial class GraphicConnector : DataModel
    {
        public GraphicConnector?                        S_EmptyConnector                        { get; set; }

        public static GraphicConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphicConnector() { Pointer= p0 };

            value.S_EmptyConnector                          = GetObject<GraphicConnector>(new IntPtr(p + 0x010), ReversePrism.DataModels.GraphicConnector.FromPointer); // 0245A3BCCBD0 0x10 S_EmptyConnector            ( 000186692F70 ModelClassType GraphicConnector GraphicConnector GraphicConnector Pointer )

            return value;
        }
    }
}
