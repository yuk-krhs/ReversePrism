using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Pool                                   ObjectPool`1<AreaNode> IL2CPP_TYPE_GENERICINST
    // 010 Rect                                     000186651230 ModelEnumType RectInt RectInt RectInt Int32
    // 020 Previous                                 000186660160 ModelClassType AreaNode AreaNode AreaNode Pointer
    // 028 Next                                     000186660160 ModelClassType AreaNode AreaNode AreaNode Pointer
    public partial class AreaNode
    {
        public RectInt                                  Rect                                    { get; set; }
        public AreaNode?                                Previous                                { get; set; }
        public AreaNode?                                Next                                    { get; set; }

        public static AreaNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AreaNode();

            value.Rect                                      = (RectInt)GetInt32(new IntPtr(p + 0x010)); // 0270067E26B0 0x10 Rect                        ( 000186651230 ModelEnumType RectInt RectInt RectInt Int32 )
            value.Previous                                  = GetObject<AreaNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.AreaNode.FromPointer); // 0270067E26D0 0x20 Previous                    ( 000186660160 ModelClassType AreaNode AreaNode AreaNode Pointer )
            value.Next                                      = GetObject<AreaNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.AreaNode.FromPointer); // 0270067E26F0 0x28 Next                        ( 000186660160 ModelClassType AreaNode AreaNode AreaNode Pointer )

            return value;
        }
    }
}
