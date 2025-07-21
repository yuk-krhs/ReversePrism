using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourceData                               ModelClassType IGetVersionReply IGetVersionReply IGetVersionReply Pointer
    // 018 IsReady                                  ModelPrimitiveType bool bool bool Bool
    public partial class GameVersionCache : DataModel
    {
        public IGetVersionReply?                        SourceData                              { get; set; }
        public bool                                     IsReady                                 { get; set; }

        public static GameVersionCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameVersionCache() { Pointer= p0 };

            value.SourceData                                = GetObject<IGetVersionReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGetVersionReply.FromPointer); // 0x10 SourceData                  ( ModelClassType IGetVersionReply IGetVersionReply IGetVersionReply Pointer )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 IsReady                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
