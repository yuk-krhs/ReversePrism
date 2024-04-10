using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 tokens                                   IList`1<JsonToken> IL2CPP_TYPE_GENERICINST
    // 028 NextTokenizer                            000186762F90 ModelClassType JsonTokenizer JsonTokenizer JsonTokenizer Pointer
    // 030 NextTokenIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class JsonReplayTokenizer : DataModel
    {
        public JsonTokenizer?                           NextTokenizer                           { get; set; }
        public int                                      NextTokenIndex                          { get; set; }

        public static JsonReplayTokenizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonReplayTokenizer() { Pointer= p0 };

            value.NextTokenizer                             = GetObject<JsonTokenizer>(new IntPtr(p + 0x028), ReversePrism.DataModels.JsonTokenizer.FromPointer); // 02466A47D248 0x28 NextTokenizer               ( 000186762F90 ModelClassType JsonTokenizer JsonTokenizer JsonTokenizer Pointer )
            value.NextTokenIndex                            = GetInt32(new IntPtr(p + 0x030)); // 02466A47D268 0x30 NextTokenIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
