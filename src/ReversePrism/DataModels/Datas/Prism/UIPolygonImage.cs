using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 Vertecies                                000185CC4948 ModelClassListType VertexParameter[] VertexParameter[] List<VertexParameter> Pointer
    // 0B0 Texture                                  000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    public partial class UIPolygonImage : DataModel
    {
        public List<VertexParameter>?                   Vertecies                               { get; set; }
        public Texture2D?                               Texture                                 { get; set; }

        public static UIPolygonImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIPolygonImage() { Pointer= p0 };

            value.Vertecies                                 = GetObjectList<VertexParameter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.VertexParameter.FromPointer); // 0245A69554E0 0xA8 Vertecies                   ( 000185CC4948 ModelClassListType VertexParameter[] VertexParameter[] List<VertexParameter> Pointer )
            value.Texture                                   = GetObject<Texture2D>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A6955500 0xB0 Texture                     ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
