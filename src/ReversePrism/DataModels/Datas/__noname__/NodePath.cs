using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _nodeID                                  int IL2CPP_TYPE_I4
    // 000 _mainTreeNodeID                          int IL2CPP_TYPE_I4
    public partial class NodePath
    {

        public static NodePath? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NodePath();


            return value;
        }
    }
}
