using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   000186689CF0 ModelClassType IUniTaskSource IUniTaskSource IUniTaskSource Pointer
    // 018 Token                                    0001865F1780 ModelPrimitiveType short short short Int16
    // 000 CanceledUniTask                          UniTask IL2CPP_TYPE_VALUETYPE
    // 010 CompletedTask                            0001866A06A0 ModelEnumType UniTask UniTask UniTask Int32
    public partial class UniTask
    {
        public IUniTaskSource?                          Source                                  { get; set; }
        public short                                    Token                                   { get; set; }
        public UniTask                                  CompletedTask                           { get; set; }

        public static UniTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniTask();

            value.Source                                    = GetObject<IUniTaskSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUniTaskSource.FromPointer); // 027003CBC7F0 0x10 Source                      ( 000186689CF0 ModelClassType IUniTaskSource IUniTaskSource IUniTaskSource Pointer )
            value.Token                                     = GetInt16(new IntPtr(p + 0x018)); // 027003CBC810 0x18 Token                       ( 0001865F1780 ModelPrimitiveType short short short Int16 )
            value.CompletedTask                             = (UniTask)GetInt32(new IntPtr(p + 0x010)); // 027003CBC850 0x10 CompletedTask               ( 0001866A06A0 ModelEnumType UniTask UniTask UniTask Int32 )

            return value;
        }
    }
}
