using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EUp                                      ModelClassType Edge Edge Edge Pointer
    // 018 _nodeUp                                  Node<ActiveRegion> IL2CPP_TYPE_GENERICINST
    // 020 WindingNumber                            ModelPrimitiveType int int int Int32
    // 024 Inside                                   ModelPrimitiveType bool bool bool Bool
    // 025 Sentinel                                 ModelPrimitiveType bool bool bool Bool
    // 026 Dirty                                    ModelPrimitiveType bool bool bool Bool
    // 027 FixUpperEdge                             ModelPrimitiveType bool bool bool Bool
    public partial class ActiveRegion : DataModel
    {
        public Edge?                                    EUp                                     { get; set; }
        public int                                      WindingNumber                           { get; set; }
        public bool                                     Inside                                  { get; set; }
        public bool                                     Sentinel                                { get; set; }
        public bool                                     Dirty                                   { get; set; }
        public bool                                     FixUpperEdge                            { get; set; }

        public static ActiveRegion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActiveRegion() { Pointer= p0 };

            value.EUp                                       = GetObject<Edge>(new IntPtr(p + 0x010), ReversePrism.DataModels.Edge.FromPointer); // 0x10 EUp                         ( ModelClassType Edge Edge Edge Pointer )
            value.WindingNumber                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 WindingNumber               ( ModelPrimitiveType int int int Int32 )
            value.Inside                                    = GetBool(new IntPtr(p + 0x024)); // 0x24 Inside                      ( ModelPrimitiveType bool bool bool Bool )
            value.Sentinel                                  = GetBool(new IntPtr(p + 0x025)); // 0x25 Sentinel                    ( ModelPrimitiveType bool bool bool Bool )
            value.Dirty                                     = GetBool(new IntPtr(p + 0x026)); // 0x26 Dirty                       ( ModelPrimitiveType bool bool bool Bool )
            value.FixUpperEdge                              = GetBool(new IntPtr(p + 0x027)); // 0x27 FixUpperEdge                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
