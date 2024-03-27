using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 LogDatas                                 000185CFC818 ModelClassListType List`1<ProduceLogData> List`1<ProduceLogData> List<ProduceLogData> Pointer
    public partial class ProduceLogCache
    {
        public bool                                     IsReady                                 { get; set; }
        public List<ProduceLogData>?                    LogDatas                                { get; set; }

        public static ProduceLogCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceLogCache();

            value.IsReady                                   = GetBool(new IntPtr(p + 0x010)); // 027004A8A118 0x10 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LogDatas                                  = GetObjectList<ProduceLogData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceLogData.FromPointer); // 027004A8A138 0x18 LogDatas                    ( 000185CFC818 ModelClassListType List`1<ProduceLogData> List`1<ProduceLogData> List<ProduceLogData> Pointer )

            return value;
        }
    }
}
