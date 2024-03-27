using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseOffset                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Line                                     0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    public partial class GridLine
    {
        public int                                      BaseOffset                              { get; set; }
        public GameObject?                              Line                                    { get; set; }

        public static GridLine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GridLine();

            value.BaseOffset                                = GetInt32(new IntPtr(p + 0x010)); // 0270DB03E3F0 0x10 BaseOffset                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Line                                      = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB03E410 0x18 Line                        ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
